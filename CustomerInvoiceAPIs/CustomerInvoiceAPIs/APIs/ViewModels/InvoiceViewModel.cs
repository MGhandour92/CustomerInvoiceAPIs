using Domain.Entities;

namespace APIs.ViewModels
{
    public class InvoiceViewModel
    {
        public InvoiceHeader Header { get; set; }
        public List<InvoiceLine> Lines { get; set; }
    }
}
