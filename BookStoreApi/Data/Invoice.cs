using System;
using System.Collections.Generic;

namespace BookStoreApi.Data
{
    public partial class Invoice
    {
        public Invoice()
        {
            InvoiceDetails = new HashSet<InvoiceDetail>();
        }

        public int InvoiceId { get; set; }
        public string? MemberId { get; set; }
        public string? Email { get; set; }
        public string? Tel { get; set; }
        public string? Address { get; set; }
        public int? StatusId { get; set; }
        public DateTime? AddedDate { get; set; }

        public virtual Status? Status { get; set; }
        public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; }
    }
}
