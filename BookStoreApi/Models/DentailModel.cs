namespace BookStoreApi.Models
{
    public class DentailModel
    {
        public int InvoiceId { get; set; }
        public int ProductId { get; set; }
        public short? Quantify { get; set; }
        public int? Price { get; set; }

    }
    public class DetailOfInvoice
    {
        public int ProducId { get; set; }
        public int Quantity { get; set; }
        public int? Price { get; set; }
        public string? Title { get; set; }
        public string? ImageUrl { get; set; }
    }
}
