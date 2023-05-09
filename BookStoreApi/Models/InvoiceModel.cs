namespace BookStoreApi.Models
{
    public class InvoiceModel
    {
        public int InvoiceId { get; set; }
        public string? MemberId { get; set; }
        public string? Email { get; set; }
        public string? Tel { get; set; }
        public string? Address { get; set; }
        public int? StatusId { get; set; }
        public DateTime? AddedDate { get; set; }
    }
    public class InvoiceAdd
    {
        public string? MemberId { get; set; }
        public string? Email { get; set; }
        public string? Tel { get; set; }
        public string? Address { get; set; }
    }
    public class InvoiceUpdate
    {
        public string? Email { get; set; }
        public string? Tel { get; set; }
        public string? Address { get; set; }
    }
}
