using BookStoreApi.Data;
using BookStoreApi.Models;
using AutoMapper;
using AutoMapper.Execution;
using Microsoft.EntityFrameworkCore;
using BookStoreApi.Helper;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static System.Reflection.Metadata.BlobBuilder;
using System.Drawing;

namespace BookStoreApi.Reposities
{
    public class BookReposities : IBookReposities
    {
        private readonly BookStoreContext _context;
        private readonly IMapper _mapper;
        public static int PAGE_SIZE { get; set; } = 12;

        public BookReposities(BookStoreContext context, IMapper mapper) 
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<int> AddBookAsync(BookAdd model)
        {
            var newBook = _mapper.Map<Product>(model);
             _context.Products!.Add(newBook);
            await _context.SaveChangesAsync();
            return newBook.ProductId;
        }

        public async Task<int> DeleteBookAsync(int id)
        {
            var deleteBook = _context.Products!.SingleOrDefault(m => m.ProductId == id);
            var carItem = _context.CartItems!.FirstOrDefault(m => m.ProductId == id);
            var dentai = _context.InvoiceDetails!.FirstOrDefault(m => m.ProductId == id);
            if (deleteBook != null && carItem == null && dentai == null)
            {
                _context.Products!.Remove(deleteBook);
                await _context.SaveChangesAsync();
                return 0;
            }
            return 1;
        }

        public async Task<List<BookOfTitle>> getAllBookAsync(int page = 1)
        {
            var books = _context.Products!.AsQueryable().Where(pr => pr.ProductId != 0);
            int pages = (int)Math.Ceiling((double)books.Count() / PAGE_SIZE); 
            var result = PaginatedList<Product>.Creat(books, page,PAGE_SIZE);
            return result.Select(pr => new BookOfTitle
            {
                ProductId = pr.ProductId,
                AuthorId = pr.AuthorId,
                CategoryId = pr.CategoryId,
                PublisherId = pr.PublisherId,
                Descreption = pr.Descreption,
                Year = pr.Year,
                Title = pr.Title,
                ImageUrl = pr.ImageUrl,
                Price = pr.Price,
                SoLuong = pr.SoLuong,
                pages = pages

            }).ToList();

        }

        public List<BookOfTitle> GetAllBookOfTitleAsync(string search,int page = 1)
        {
            var allProducts = _context.Products!.AsQueryable().Where(pr => pr.Title.Contains(search));          

            int pages = (int)Math.Ceiling((double)allProducts.Count() / PAGE_SIZE);
            var result = PaginatedList<Product>.Creat(allProducts, page, PAGE_SIZE);

            return result.Select(pr => new BookOfTitle
            {
                ProductId = pr.ProductId,
                AuthorId = pr.AuthorId,
                CategoryId = pr.CategoryId,
                PublisherId = pr.PublisherId,
                Descreption = pr.Descreption,
                Year = pr.Year,
                Title = pr.Title,
                ImageUrl = pr.ImageUrl,
                Price = pr.Price,
                SoLuong = pr.SoLuong,
                pages = pages

            }).ToList();
        }

        public async Task<BookModel> getBookAsync(int id)
        {
            var book = await _context.Products!.FindAsync(id);
            return _mapper.Map<BookModel>(book);
        }

        public async Task<BookInfo> GetBookInfoAsync(int id)
        {
            var book = await _context.Products!.FindAsync(id);
            var category = _context.Categories!.SingleOrDefault(m => m.CategoryId == book.CategoryId);
            var author = _context.Authors!.SingleOrDefault(m => m.AuthorId == book.AuthorId);
            var publisher = _context.Publishers!.SingleOrDefault(m => m.PublisherId == book.PublisherId);
            if (category != null && author!= null && publisher != null && book != null) 
            {
                var bookInfo = new BookInfo()
                {
                    ProductId=book.ProductId,
                    CategoryName = category.CategoryName,
                    PublisherName = publisher.PublisherName,
                    AuthorName = author.AuthorName,
                    Title = book.Title,
                    Descreption = book.Descreption,
                    Year = book.Year,
                    ImageUrl = book.ImageUrl,
                    Price = book.Price,
                };
                return bookInfo;
            }
            return null;

        }

        public List<BookOfTitle> GetBookOfCatgoryAsync(int catgoryId,int page =1)
        {
            var allProducts = _context.Products!.AsQueryable().Where(pr => pr.CategoryId == catgoryId);
            var result = PaginatedList<Product>.Creat(allProducts, page, PAGE_SIZE);
            int pages = (int)Math.Ceiling((double)allProducts.Count() / PAGE_SIZE);
            return result.Select(pr => new BookOfTitle
           {
                ProductId = pr.ProductId,
                AuthorId = pr.AuthorId,
                CategoryId = pr.CategoryId,
                PublisherId = pr.PublisherId,
                Descreption = pr.Descreption,
                Year = pr.Year,
                Title = pr.Title,
                ImageUrl = pr.ImageUrl,
                Price = pr.Price,
                SoLuong = pr.SoLuong,
                pages = pages
                
            }).ToList();
        }

        public async Task UpdateBookAsync(int id, BookModel bookModel)
        {
            if (id == bookModel.ProductId)
            {
                var updateBook = _mapper.Map<Product>(bookModel);
                _context.Products!.Update(updateBook);
                await _context.SaveChangesAsync();


            }
        }

        public List<BookOfTitle> GetRandomBook()
        {
            var books = _context.Products!.ToList();
            var random = new Random();
            var result = books.OrderBy(x => random.Next()).Take(5).ToList();
            return result.Select(pr => new BookOfTitle
            {
                ProductId = pr.ProductId,
                AuthorId = pr.AuthorId,
                CategoryId = pr.CategoryId,
                PublisherId = pr.PublisherId,
                Descreption = pr.Descreption,
                Year = pr.Year,
                Title = pr.Title,
                ImageUrl = pr.ImageUrl,
                Price = pr.Price,
                SoLuong = pr.SoLuong,

            }).ToList();
        }
    }
}
