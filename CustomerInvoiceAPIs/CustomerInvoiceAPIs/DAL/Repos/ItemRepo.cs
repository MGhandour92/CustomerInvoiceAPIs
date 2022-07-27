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
    public class ItemRepo : GenericRepo<Item>, IItemRepo
    {
        public ItemRepo(AppDBContext context) : base(context)
        {
        }
    }
}
