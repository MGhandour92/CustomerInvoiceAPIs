using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class InvoiceHeader
    {
        public int Id { get; set; }
        public int InvoiceNumber { get; set; }
        public int? CustomerId { get; set; }
        public virtual Customer? Customer { get; set; }

        public virtual List<InvoiceLine>? InvoiceLines { get; set; }
    }
}
