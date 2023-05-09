using BookStoreApi.Models;

namespace BookStoreApi.Reposities
{
    public interface IDetailReposities
    {
        public Task<List<DetailOfInvoice>> GetDetailOfInvoiceAsync(int invoiceId);
    }
}
