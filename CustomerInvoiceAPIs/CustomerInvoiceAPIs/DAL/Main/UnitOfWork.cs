using DAL.Repos;
using Domain.Interfaces;
using Domain.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Main
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDBContext _context;

        public IWeatherForecastRepo WeatherForecasts { get; private set; }
        public ICustomerRepo Customers { get; private set; }
        public IItemRepo Items { get; private set; }
        public IInvoiceHeaderRepo InvoiceHeaders { get; private set; }
        public IInvoiceLineRepo InvoicLines { get; private set; }

        public UnitOfWork(AppDBContext context)
        {
            _context = context;
            WeatherForecasts = new WeatherForecastRepo(_context);
            Customers = new CustomerRepo(_context);
            Items = new ItemRepo(_context);
            InvoiceHeaders = new InvoiceHeaderRepo(_context);
            InvoicLines = new InvoiceLineRepo(_context);
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
