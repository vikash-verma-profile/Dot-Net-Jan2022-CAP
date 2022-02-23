using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EFCoreDemo.Models
{
    public partial class SampleContext : DbContext
    {
        public SampleContext()
        {
        }

        public SampleContext(DbContextOptions<SampleContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeDetail> EmployeeDetails { get; set; }
        public virtual DbSet<Employeedepartmentmapping> Employeedepartmentmappings { get; set; }
        public virtual DbSet<Name> Names { get; set; }
        public virtual DbSet<UserHistroy> UserHistroys { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=Sample;Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Department");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Employee");

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("employeeName");

                entity.Property(e => e.Employeeid).HasColumnName("employeeid");

                entity.Property(e => e.Gender)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmployeeDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EmployeeDetail");

                entity.Property(e => e.Employeename)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("employeename");

                entity.Property(e => e.Gender)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("gender");

                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<Employeedepartmentmapping>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("employeedepartmentmapping");

                entity.Property(e => e.DepartmentId).HasColumnName("departmentId");

                entity.Property(e => e.EmployeeId).HasColumnName("employeeID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");
            });

            modelBuilder.Entity<Name>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name1)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("Name");
            });

            modelBuilder.Entity<UserHistroy>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("userHistroy");

                entity.Property(e => e.Description)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
