using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortgageFraudContexts
{
    public class MortgageContext : DbContext
    {
        public MortgageContext(DbContextOptions<MortgageContext> options) : base(options)
        {

        }

        public DbSet<MortgageContext> Buyer { get; set; } = null!;
        public DbSet<MortgageContext> ValuationReport { get; set; } = null!;
    }
}
