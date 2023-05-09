using AutoMapper;
using AutoMapper.Execution;
using BookStoreApi.Data;
using BookStoreApi.Migrations;
using BookStoreApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStoreApi.Reposities
{
    public class InvoiceReposities : IInvoiceReposities
    {
        private readonly BookStoreContext _context;
        private readonly IMapper _mapper;

        public InvoiceReposities(BookStoreContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        
        public async Task<int> AddInvoiceAsync(InvoiceAdd model)
        {
            //kiem tra gio hang co san pham khong
            var cart = _context.Carts.SingleOrDefault(pr => pr.MemberId.Contains(model.MemberId));
            var dateteCartItem = _context.CartItems.Where(pr => pr.CartId == cart.CartId);
            if (dateteCartItem.Count() > 0)
            {

                // them don hang
                var newInvoice = new Invoice()
                {
                    MemberId = model.MemberId,
                    Email = model.Email,
                    Tel = model.Tel,
                    Address = model.Address,
                    StatusId = 1,
                    AddedDate = DateTime.Now,

                };
                _context.Invoices!.Add(newInvoice);
                await _context.SaveChangesAsync();
                //  them thong tin chi tiet don hang
                var newCartItem = from c in _context.CartItems
                                  join p in _context.Products on c.ProductId equals p.ProductId
                                  where c.CartId == cart.CartId
                                  select new
                                  {
                                      ProducId1 = c.ProductId,
                                      Quantity1 = c.Quantity,
                                      Price1 = p.Price,
                                  };
                foreach (var cartItem in newCartItem)
                {
                    var totalPrice = cartItem.Quantity1 * cartItem.Price1;
                    var newDetail = new InvoiceDetail()
                    {
                        InvoiceId = newInvoice.InvoiceId,
                        ProductId = cartItem.ProducId1,
                        Quantify = (short)cartItem.Quantity1,
                        Price = totalPrice

                    };
                    _context.InvoiceDetails!.Add(newDetail);
                   
                }
                /// xoa gio hang
                var deleteCart = _context.Carts!.SingleOrDefault(m => m.CartId == cart.CartId);
                if (deleteCart != null)
                {
                    foreach (var cartItem in dateteCartItem)
                        _context.CartItems!.Remove(cartItem);
                    _context.Carts!.Remove(deleteCart);
                }
                // tao gio hang moi
                var newCart = new Cart
                {
                    CartId = Guid.NewGuid(),
                    MemberId = model.MemberId,
                };
                _context.Carts!.Add(newCart);
                // luu 
                await _context.SaveChangesAsync();
                return newInvoice.InvoiceId;
            }
            return 0;
        }

        public async Task DeleteInvoiceAsync(int id)
        {
            var deleteInvoice = _context.Invoices!.SingleOrDefault(m => m.InvoiceId == id);
            var datetedetail  = _context.InvoiceDetails.Where(pr => pr.InvoiceId == id);
            if (deleteInvoice != null && datetedetail != null)
            {
                foreach (var detail in datetedetail)
                    _context.InvoiceDetails!.Remove(detail);
                _context.Invoices!.Remove(deleteInvoice);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<InvoiceModel>> getAllInvoiceAsync()
        {
            var invoices = await _context.Invoices!.ToListAsync();
            return _mapper.Map<List<InvoiceModel>>(invoices);
        }

        public async Task<InvoiceModel> getInvoiceAsync(int id)
        {
            var invoice = await _context.Invoices!.FindAsync(id);
            return _mapper.Map<InvoiceModel>(invoice);
        }

        public async Task<List<InvoiceModel>> getInvoiceOfStatusAsync(int statusId)
        {
            var allInvoice = _context.Invoices.Where(pr => pr.StatusId == statusId);
            var resual = allInvoice.Select(pr => new InvoiceModel
            {
                InvoiceId = pr.InvoiceId,
                MemberId = pr.MemberId,
                Email = pr.Email,
                StatusId = pr.StatusId,
                AddedDate = pr.AddedDate,
                Address = pr.Address,
                Tel = pr.Tel,

            });

            return resual.ToList();
        }

        public async Task<List<InvoiceModel>> GetInvoiceOfUserAsync(string memberId)
        {
            var allInvoice = _context.Invoices.Where(pr => pr.MemberId.Contains(memberId));
            
            var resual = allInvoice.Select(pr => new InvoiceModel
            {
                InvoiceId = pr.InvoiceId,
                MemberId = memberId,
                Email = pr.Email,
                StatusId = pr.StatusId,
                AddedDate = pr.AddedDate,
                Address = pr.Address,
                Tel = pr.Tel,

            });

            return resual.ToList();
        }

        public async Task UpdateInvoiceAsync(int id, InvoiceUpdate Model)
        {
            var invoice = _context.Invoices!.SingleOrDefault(m => m.InvoiceId == id);
            if (invoice != null && invoice.StatusId == 1)
            {
                invoice.Email = Model.Email;
                invoice.Tel = Model.Tel;
                invoice.Address = Model.Address;
                _context.Invoices!.Update(invoice);
                await _context.SaveChangesAsync();


            }
        }

        public async Task UpdateStatusOfInvoiceAsync(int id, int statusId)
        {
            var invoice = _context.Invoices!.SingleOrDefault(m => m.InvoiceId == id);
            if (invoice != null)
            {
                if(statusId == 2) 
                {
                    // update book
                    var alldetails = from d in _context.InvoiceDetails
                                      join p in _context.Products on d.ProductId equals p.ProductId
                                      where d.InvoiceId == invoice.InvoiceId
                                      select new
                                      {
                                          ProducId1 = d.ProductId,
                                          Quantity1 = d.Quantify,
                                          Price1 = p.Price,
                                          //////
                                          CategoryId1 = p.CategoryId,
                                          PublisherId1 = p.PublisherId,
                                          AuthorId1 = p.AuthorId,
                                          Title1 = p.Title,
                                          Descreption1 = p.Descreption,
                                          Year1 = p.Year,
                                          ImageUrl1 = p.ImageUrl,
                                          SoLuong1 = p.SoLuong,

                                      };
                    foreach (var detail in alldetails)
                    {
                        int soluong = (int)(detail.SoLuong1 - detail.Quantity1);
                        var book = new Product()
                        {
                            ProductId = detail.ProducId1,
                            CategoryId = detail.CategoryId1,
                            PublisherId = detail.PublisherId1,
                            AuthorId = detail.AuthorId1,
                            Title = detail.Title1,
                            Descreption = detail.Descreption1,
                            Year = detail.Year1,
                            ImageUrl = detail.ImageUrl1,
                            SoLuong = soluong,
                            Price = detail.Price1,
                        };
                        _context.Products.Update(book);
                    }

                }
                invoice.StatusId = statusId;
                _context.Invoices!.Update(invoice);
                await _context.SaveChangesAsync();
            }
        }
    }
}
