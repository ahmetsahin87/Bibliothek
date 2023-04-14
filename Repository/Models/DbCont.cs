
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public class DbCont : DbContext
    {
        //public DbCont(DbContextOptions<DbCont> options):base(options)
        //    { }
      
        public DbSet<Ausleih> Ausleihs { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<Buch> Buches { get; set; }
        public DbSet<Benutzer> Benutzer { get; set; }
        public DbSet<Verlag> Verlags { get; set; }

        protected override void OnConfiguring(
           DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Bibliothek2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        }

    }
}
