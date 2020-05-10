namespace FedtWebAPIService
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FedtModel : DbContext
    {
        public FedtModel()
            : base("name=FedtDBContext")
        {
            base.Configuration.LazyLoadingEnabled = false;
            base.Configuration.ProxyCreationEnabled = false;
        }

        public virtual DbSet<Equipment> Equipments { get; set; }
        public virtual DbSet<Excercise> Excercises { get; set; }
        public virtual DbSet<MuscleGroup> MuscleGroups { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Equipment>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Excercise>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Excercise>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<MuscleGroup>()
                .Property(e => e.Name)
                .IsUnicode(false);
        }
    }
}
