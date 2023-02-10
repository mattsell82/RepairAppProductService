using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace IProductService
{
    public partial class ProduktModell : DbContext
    {
        public ProduktModell()
            : base("name=ProduktModell")
        {
        }

        public virtual DbSet<Produkter> Produkter { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
