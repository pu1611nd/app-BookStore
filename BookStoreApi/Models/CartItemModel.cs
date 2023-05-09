namespace BookStoreApi.Models
{
    public class CartItemModel
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public Guid CartId { get; set; }
    }

    public class CartItemOfMember
    {
        public int CartItemId { get; set; }
        public int ProducId { get; set; }
        public int Quantity { get; set; }
        public int? Price { get; set; }
        public string? Title { get; set; }
        public string? ImageUrl { get; set; }
    }
  
}
