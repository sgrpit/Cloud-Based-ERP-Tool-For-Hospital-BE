using Cloud_Based_ERP_Tool_For_Hospital_BE.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cloud_Based_ERP_Tool_For_Hospital_BE
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Staffs> Staffs { get; set; }
        public DbSet<Patients> Patients { get; set; }
        public DbSet<PatientAppointment> PatientAppointments { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<LoginDetails> LoginDetails { get; set; }
        public DbSet<PatientPrescriptionHistory> PatientPrescriptionHistories { get; set; }
        public DbSet<InPatientDirectory> InPatientDirectory { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Staffs>()
                .HasOne<Department>(e => e.Departments)
                .WithMany(d => d.Staffs)
                .HasForeignKey(e => e.DepartmentsId)
                .IsRequired(true)
                .OnDelete(DeleteBehavior.ClientNoAction);

            modelBuilder.Entity<Staffs>(entity =>
            {
                entity.HasIndex(c => c.MobileNo).IsUnique();
                entity.HasIndex(c => c.EmailId).IsUnique();
            });

            modelBuilder.Entity<Patients>(entity =>
            {
                entity.HasIndex(c => c.PatientUHID).IsUnique();
                entity.HasIndex(c => c.MobileNo).IsUnique();
                entity.HasIndex(c => c.EmailID).IsUnique();
            });

        }
    }
}
