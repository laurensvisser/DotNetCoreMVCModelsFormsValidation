using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DotNetCoreMVCModelsFormsValidation.Entities
{
    public partial class MaaltijdContext : DbContext
    {
        public virtual DbSet<Maaltijd> Maaltijd { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Maaltijden;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Maaltijd>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Naam)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Prijs).HasColumnType("money");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnType("nchar(10)");
            });
        }
    }
}
