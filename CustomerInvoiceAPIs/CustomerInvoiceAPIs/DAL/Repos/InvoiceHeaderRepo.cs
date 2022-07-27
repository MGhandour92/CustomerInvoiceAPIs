using DAL.Main;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class InvoiceHeaderRepo : GenericRepo<InvoiceHeader>, IInvoiceHeaderRepo
    {
        public InvoiceHeaderRepo(AppDBContext context) : base(context)
        {
        }

        public IEnumerable<InvoiceHeader> GetFullInvoices()
        {
            //        var receptions = dbContext.Receptions
            //.Include(r => r.Pallets
            //    .Select(p => p.PalletDetail
            //        .Select(pd => pd.Package)))
            //.ToList());

            var allh = _context.InvoiceHeaders;
            var allLines = _context.InvoiceLines;
            var allInvoiceHeaders = _context.InvoiceHeaders.Include(e => e.InvoiceLines).ThenInclude(s=>s.Item).Include(c=>c.Customer).ToList();

            return allInvoiceHeaders;
        }
    }
}
