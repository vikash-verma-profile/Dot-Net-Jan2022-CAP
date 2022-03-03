using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebApiWithEF.Models
{
    public partial class HRMSContext : DbContext
    {
        public HRMSContext()
        {
        }

        public HRMSContext(DbContextOptions<HRMSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblDepartment> TblDepartments { get; set; }
        public virtual DbSet<TblEmployee> TblEmployees { get; set; }
        public virtual DbSet<TblLogin> TblLogins { get; set; }
        public virtual DbSet<TblSalaryBand> TblSalaryBands { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=HRMS;Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TblDepartment>(entity =>
            {
                entity.ToTable("tblDepartment");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedOn).HasColumnType("date");

                entity.Property(e => e.DepartmentName).HasMaxLength(50);

                entity.Property(e => e.UpdatedOn).HasColumnType("date");
            });

            modelBuilder.Entity<TblEmployee>(entity =>
            {
                entity.ToTable("tblEmployee");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AlternateEmailId)
                    .HasMaxLength(100)
                    .HasColumnName("AlternateEmailID");

                entity.Property(e => e.CreatedOn).HasColumnType("date");

                entity.Property(e => e.DateOfJoining).HasColumnType("date");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.EmailId)
                    .HasMaxLength(100)
                    .HasColumnName("EmailID");

                entity.Property(e => e.EmployeeId).HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.UpdatedOn).HasColumnType("date");
            });

            modelBuilder.Entity<TblLogin>(entity =>
            {
                entity.ToTable("tblLogin");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedOn).HasColumnType("date");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.UpdatedOn).HasColumnType("date");

                entity.Property(e => e.UserName).HasMaxLength(200);
            });

            modelBuilder.Entity<TblSalaryBand>(entity =>
            {
                entity.ToTable("tblSalaryBand");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BandName).HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("date");

                entity.Property(e => e.UpdatedOn).HasColumnType("date");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
