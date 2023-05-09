using System;
using System.Collections.Generic;

namespace BookStoreApi.Data
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public int? ParentId { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
