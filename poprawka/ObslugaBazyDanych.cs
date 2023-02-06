using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poprawka
{
    internal class ObslugaBazyDanych : DbContext
    {
        public DbSet<Towar> towar { get; set; }
        public DbSet<StanMagazynowy> stanMagazynowy { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlite("Data Source=poprawka.db");
            base.OnConfiguring(dbContextOptionsBuilder);
        }
    }
}
