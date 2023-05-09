using System;
using System.Collections.Generic;

namespace BookStoreApi.Data
{
    public partial class Cart
    {
        public Cart()
        {
            CartItems = new HashSet<CartItem>();
        }

        public Guid CartId { get; set; }
        public string MemberId { get; set; } = null!;

        public virtual ICollection<CartItem> CartItems { get; set; }
    }
}
