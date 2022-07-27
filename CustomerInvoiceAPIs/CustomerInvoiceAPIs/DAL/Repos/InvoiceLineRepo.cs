using DAL.Main;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class InvoiceLineRepo : GenericRepo<InvoiceLine>, IInvoiceLineRepo
    {
        public InvoiceLineRepo(AppDBContext context) : base(context)
        {
        }
    }
}
