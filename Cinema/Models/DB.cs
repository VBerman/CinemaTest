using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Cinema.Models
{
    public partial class DB : DbContext
    {
        public DB()
            : base("name=DB")
        {
        }

        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<Disctrict> Disctrict { get; set; }
        public virtual DbSet<Receipt> Receipt { get; set; }
        public virtual DbSet<ReceiptService> ReceiptService { get; set; }
        public virtual DbSet<Service> Service { get; set; }
        public virtual DbSet<Staff> Staff { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Receipt>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Service>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);
        }
    }
}
