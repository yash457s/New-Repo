using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApp_Azure.Models
{
    public partial class yashdbContext : DbContext
    {
        public yashdbContext()
        {
        }

        public yashdbContext(DbContextOptions<yashdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Emp> Emp { get; set; }
        public virtual DbSet<Salary> Salary { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(" Server=tcp:yashserver0901.database.windows.net,1433;Initial Catalog=yashdb;Persist Security Info=False;User ID=Admin0901;Password=A7415434573@z ;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Emp>(entity =>
            {
                entity.Property(e => e.EmpId).ValueGeneratedNever();

                entity.Property(e => e.EmpName).HasMaxLength(40);

                entity.Property(e => e.EmpSalary).HasMaxLength(40);
            });

            modelBuilder.Entity<Salary>(entity =>
            {
                entity.HasKey(e => e.Pbid)
                    .HasName("PK__Salary__5844EBD42D115546");

                entity.Property(e => e.Pbid)
                    .HasColumnName("PBId")
                    .ValueGeneratedNever();

                entity.Property(e => e.PayBand).HasMaxLength(40);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
