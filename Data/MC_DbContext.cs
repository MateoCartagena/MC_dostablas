using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MC_dostalas.Models;

namespace MC_dostalas.Data
{
    public class MC_DbContext : DbContext
    {
        public MC_DbContext (DbContextOptions<MC_DbContext> options)
            : base(options)
        {
        }

        public DbSet<MC_dostalas.Models.Burger> Burger { get; set; } = default!;

        public DbSet<MC_dostalas.Models.Promo>? Promo { get; set; }
    }
}
