namespace FedtWebAPIService
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Register")
        {
        }

        public virtual DbSet<Table> Tables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Table>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<Table>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Table>()
                .Property(e => e.Email)
                .IsUnicode(false);
        }
    }
}
