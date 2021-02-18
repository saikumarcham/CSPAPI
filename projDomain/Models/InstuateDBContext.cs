using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace projDomain.Models
{
    public partial class InstuateDBContext : DbContext
    {
        public InstuateDBContext()
        {
        }

        public InstuateDBContext(DbContextOptions<InstuateDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<StudentAddressTd> StudentAddressTds { get; set; }
        public virtual DbSet<StudentTd> StudentTds { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=LNAR-PF0ZR2W0\\MSSQLSAI;Initial Catalog=InstuateDB;Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("department");

                entity.Property(e => e.Id)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name")
                    .IsFixedLength(true);

                entity.Property(e => e.Rank).HasColumnName("rank");
            });

            modelBuilder.Entity<StudentAddressTd>(entity =>
            {
                entity.HasKey(e => e.Aid)
                    .HasName("PK__StudentA__DE508E2EA90BFE06");

                entity.ToTable("StudentAddressTD");

                entity.Property(e => e.Aid)
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("aid");

                entity.Property(e => e.City)
                    .HasMaxLength(100)
                    .HasColumnName("city");

                entity.Property(e => e.Sid)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("sid");

                entity.Property(e => e.Street)
                    .HasMaxLength(100)
                    .HasColumnName("street");

                entity.HasOne(d => d.SidNavigation)
                    .WithMany(p => p.StudentAddressTds)
                    .HasForeignKey(d => d.Sid)
                    .HasConstraintName("FK__StudentAddr__sid__286302EC");
            });

            modelBuilder.Entity<StudentTd>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("PK__StudentA__DDDFDD36FF1F87D3");

                entity.ToTable("StudentTD");

                entity.Property(e => e.Sid)
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("sid");

                entity.Property(e => e.Cource)
                    .HasMaxLength(100)
                    .HasColumnName("cource");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("email");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.Phone)
                    .HasMaxLength(100)
                    .HasColumnName("phone");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
