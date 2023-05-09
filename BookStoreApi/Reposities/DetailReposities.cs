using AutoMapper;
using BookStoreApi.Data;
using BookStoreApi.Models;

namespace BookStoreApi.Reposities
{
    public class DetailReposities : IDetailReposities
    {
        private readonly BookStoreContext _context;
        private readonly IMapper _mapper;

        public DetailReposities(BookStoreContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }      

        public async Task<List<DetailOfInvoice>> GetDetailOfInvoiceAsync(int invoiceId)
        {
            var allDetail = _context.InvoiceDetails.Where(p => p.InvoiceId == invoiceId);
            var resual = from d in _context.InvoiceDetails
                           join p in _context.Products on d.ProductId equals p.ProductId
                           where d.InvoiceId == invoiceId
                           select new DetailOfInvoice
                           {
                               ProducId = d.ProductId,
                               Quantity = (int)d.Quantify,
                               Price = p.Price,
                               Title = p.Title,
                               ImageUrl = p.ImageUrl,

                           };
            return resual.ToList();
        }
    }
}
