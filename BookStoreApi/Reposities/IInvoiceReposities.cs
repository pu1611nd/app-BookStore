using BookStoreApi.Models;

namespace BookStoreApi.Reposities
{
    public interface IInvoiceReposities
    {
        public Task<List<InvoiceModel>> getAllInvoiceAsync();
        public Task<InvoiceModel> getInvoiceAsync(int id);
        public Task<int> AddInvoiceAsync(InvoiceAdd model);

        public Task DeleteInvoiceAsync(int id);

        public Task UpdateInvoiceAsync(int id, InvoiceUpdate Model);

        public Task UpdateStatusOfInvoiceAsync(int id, int statusId);

        public Task<List<InvoiceModel>> getInvoiceOfStatusAsync(int statusId);

        public Task<List<InvoiceModel>> GetInvoiceOfUserAsync(string memberId);
    }
}
