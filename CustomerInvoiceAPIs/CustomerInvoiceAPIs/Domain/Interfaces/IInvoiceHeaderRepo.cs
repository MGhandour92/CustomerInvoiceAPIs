using Domain.Entities;
using Domain.Main;

namespace Domain.Interfaces
{
    public interface IInvoiceHeaderRepo : IGenericRepo<InvoiceHeader>
    {
        IEnumerable<InvoiceHeader> GetFullInvoices();
    }
}