using System;
using System.Collections.Generic;

namespace BookStoreApi.Data
{
    public partial class InvoiceDetail
    {
        public int InvoiceId { get; set; }
        public int ProductId { get; set; }
        public short? Quantify { get; set; }
        public int? Price { get; set; }

        public virtual Invoice Invoice { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
    }
}
