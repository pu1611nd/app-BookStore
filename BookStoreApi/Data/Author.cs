using System;
using System.Collections.Generic;

namespace BookStoreApi.Data
{
    public partial class Author
    {
        public Author()
        {
            Products = new HashSet<Product>();
        }

        public int AuthorId { get; set; }
        public string? AuthorName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
