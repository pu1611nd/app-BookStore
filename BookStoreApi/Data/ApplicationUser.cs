using Microsoft.AspNetCore.Identity;

namespace BookStoreApi.Data
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            Invoices = new HashSet<Invoice>();
            Carts = new HashSet<Cart>();
        }
        public string? Fullname { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
    }
}
