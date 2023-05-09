using System;
using System.Collections.Generic;

namespace BookStoreApi.Data
{
    public partial class Product
    {
        public Product()
        {
            CartItems = new HashSet<CartItem>();
            InvoiceDetails = new HashSet<InvoiceDetail>();
        }

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

        public virtual Author? Author { get; set; }
        public virtual Category? Category { get; set; }
        public virtual Publisher? Publisher { get; set; }
        public virtual ICollection<CartItem> CartItems { get; set; }
        public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; }
    }
}
