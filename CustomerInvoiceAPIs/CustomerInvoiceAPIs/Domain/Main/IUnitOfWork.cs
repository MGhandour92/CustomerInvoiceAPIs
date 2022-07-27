using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Main
{
    public interface IUnitOfWork : IDisposable
    {
        IWeatherForecastRepo WeatherForecasts { get; }
        ICustomerRepo Customers { get; }
        IItemRepo Items { get; }
        IInvoiceHeaderRepo InvoiceHeaders { get; }
        IInvoiceLineRepo InvoicLines { get; }
        int Complete();
    }
}
