using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Hospital.Models
{
    public partial class LifeCareHospitalContext : DbContext
    {
        public LifeCareHospitalContext()
        {
        }

        public LifeCareHospitalContext(DbContextOptions<LifeCareHospitalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BookAppointment> BookAppointments { get; set; }
        public virtual DbSet<Enquiry> Enquiries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("host=localhost; database=LifeCareHospital; user id=postgres; password=root;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "English_United States.1252");

            modelBuilder.Entity<BookAppointment>(entity =>
            {
                entity.ToTable("book_appointment");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("address");

                entity.Property(e => e.AppointmentDate)
                    .HasColumnType("date")
                    .HasColumnName("appointment_date");

                entity.Property(e => e.AppointmentTime)
                    .HasColumnType("time without time zone")
                    .HasColumnName("appointment_time");

                entity.Property(e => e.DoctorName)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("doctor_name");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("first_name");

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("gender");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("last_name");

                entity.Property(e => e.MobileNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("mobile_no");

                entity.Property(e => e.Speciality)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("speciality");
            });

            modelBuilder.Entity<Enquiry>(entity =>
            {
                entity.ToTable("enquiry");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("first_name");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("last_name");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("message");

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(50)
                    .HasColumnName("mobile_no");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
