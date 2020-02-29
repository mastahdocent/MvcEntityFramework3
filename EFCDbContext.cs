using Microsoft.EntityFrameworkCore;
using Rozdzial3_C.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rozdzial3_C
{
    public class EFCDbContext : DbContext
    {
        public DbSet<CustomerModel> Customers { get; set; }
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<TransactionModel> Transactions { get; set; }

        public EFCDbContext(DbContextOptions<EFCDbContext> options) : base(options) { }
    }
}
