namespace BookStoreApi.Models
{
    public class BookModel
    {
        public int ProductId { get; set; }
        public int? CategoryId { get; set; }
        public int? PublisherId { get; set; }
        public int? AuthorId { get; set; }
        public string? Title { get; set; }
        public string? Descreption { get; set; }
        public short? Year { get; set; }
        public string? ImageUrl { get; set; }
        public int? Price { get; set; }
        public int? SoLuong { get; set; }
    }
    public class BookInfo
    {
        public int ProductId { get; set; }
        public string? CategoryName { get; set; }
        public string? PublisherName { get; set; }
        public string? AuthorName { get; set; }
        public string? Title { get; set; }
        public string? Descreption { get; set; }
        public short? Year { get; set; }
        public string? ImageUrl { get; set; }
        public int? Price { get; set; }

    }
    public class BookAdd
    {
        public int? CategoryId { get; set; }
        public int? PublisherId { get; set; }
        public int? AuthorId { get; set; }
        public string? Title { get; set; }
        public string? Descreption { get; set; }
        public short? Year { get; set; }
        public string? ImageUrl { get; set; }
        public int? Price { get; set; }
        public int? SoLuong { get; set; }
    }
    public class BookOfTitle
    {
        public int ProductId { get; set; }
        public int? CategoryId { get; set; }
        public int? PublisherId { get; set; }
        public int? AuthorId { get; set; }
        public string? Title { get; set; }
        public string? Descreption { get; set; }
        public short? Year { get; set; }
        public string? ImageUrl { get; set; }
        public int? Price { get; set; }
        public int? SoLuong { get; set; }
        public int? pages { get; set; }
    }
 
}
