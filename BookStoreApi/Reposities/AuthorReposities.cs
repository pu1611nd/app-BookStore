using BookStoreApi.Data;
using BookStoreApi.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace BookStoreApi.Reposities
{
    public class AuthorReposities : IAuthorReposities
    {
        private readonly BookStoreContext _context;
        private readonly IMapper _mapper;

        public AuthorReposities(BookStoreContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<int> AddAuthorAsync(string authorName)
        {
            var author = _context.Authors!.SingleOrDefault(m => m.AuthorName == authorName);
            if (author == null)
            {
                var newAuthor = new Author()
                {
                    AuthorName = authorName,
                };
                _context.Authors!.Add(newAuthor);
                await _context.SaveChangesAsync();
                return newAuthor.AuthorId;
            }
            return 0;
            
        }

        public async Task<int> DeleteAuthorAsync(int id)
        {
            var deleteAuthor = _context.Authors!.SingleOrDefault(m => m.AuthorId == id);
            var book = _context.Products!.FirstOrDefault(m => m.AuthorId == id);
            if (deleteAuthor != null && book == null)
            {
                _context.Authors!.Remove(deleteAuthor);
                await _context.SaveChangesAsync();
                return 0;
            }
            return 1;
        }

        public async Task<List<AuthorModel>> getAllAuthorAsync()
        {
            var author = await _context.Authors!.ToListAsync();
            return _mapper.Map<List<AuthorModel>>(author);
        }

        public async Task<AuthorModel> getAuthorAsync(int id)
        {
            var author = await _context.Authors!.FindAsync(id);
            return _mapper.Map<AuthorModel>(author);
        }

        public async Task UpdateAuthorAsync(int id, string authorName)
        {

            var author = _context.Authors!.SingleOrDefault(m => m.AuthorId == id);
            if (author != null)
            {
                author.AuthorName = authorName;
                _context.Authors!.Update(author);
                await _context.SaveChangesAsync();
            }
           
        }
    }
}
