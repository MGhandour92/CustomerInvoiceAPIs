using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class InvoiceLine
    {
        public int Id { get; set; }
        public int? InvoiceHeaderId { get; set; }
        //public virtual InvoiceHeader? InvoiceHeader { get; set; }
        public int? ItemId { get; set; }
        public virtual Item? Item { get; set; }
        public double Quantity { get; set; }
    }
}
