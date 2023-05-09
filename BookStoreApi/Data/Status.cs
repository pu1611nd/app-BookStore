using System;
using System.Collections.Generic;

namespace BookStoreApi.Data
{
    public partial class Status
    {
        public Status()
        {
            Invoices = new HashSet<Invoice>();
        }

        public int StatusId { get; set; }
        public string? StatusName { get; set; }

        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}
