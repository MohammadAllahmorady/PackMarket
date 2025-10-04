using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace PackMarket.DataLayer.Context
{
    public class PackMarketContext : DbContext
    {
        public PackMarketContext(DbContextOptions<PackMarketContext> options):base(options)
        {
            
        }
    }
}
