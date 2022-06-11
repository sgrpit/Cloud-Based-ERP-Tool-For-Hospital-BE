﻿// <auto-generated />
using System;
using Cloud_Based_ERP_Tool_For_Hospital_BE;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Cloud_Based_ERP_Tool_For_Hospital_BE.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220611195718_AddreftoPatientinPresction")]
    partial class AddreftoPatientinPresction
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Cloud_Based_ERP_Tool_For_Hospital_BE.Domain.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DepartmentDesc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("Cloud_Based_ERP_Tool_For_Hospital_BE.Domain.InPatientDirectory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AdminssionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("BedNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedOn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiagnosisDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DischargeDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DischargeSummary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InsuranceCompany")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDischarged")
                        .HasColumnType("bit");

                    b.Property<bool>("IsInsured")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedOn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<string>("PatientUHID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoomType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StaffId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PatientId");

                    b.HasIndex("StaffId");

                    b.ToTable("InPatientDirectory");
                });

            modelBuilder.Entity("Cloud_Based_ERP_Tool_For_Hospital_BE.Domain.LoginDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("StaffId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPassword")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("StaffId");

                    b.ToTable("LoginDetails");
                });

            modelBuilder.Entity("Cloud_Based_ERP_Tool_For_Hospital_BE.Domain.PatientAppointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AppointmentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("AppointmentTimeLSlot")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedOn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("EmailID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsCancelled")
                        .HasColumnType("bit");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.Property<string>("MobileNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedOn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<string>("PatientName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StaffId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PatientId");

                    b.HasIndex("StaffId");

                    b.ToTable("PatientAppointments");
                });

            modelBuilder.Entity("Cloud_Based_ERP_Tool_For_Hospital_BE.Domain.PatientPrescriptionHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DrugName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DrugType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAfternoon")
                        .HasColumnType("bit");

                    b.Property<bool>("IsBeforeFood")
                        .HasColumnType("bit");

                    b.Property<bool>("IsEvening")
                        .HasColumnType("bit");

                    b.Property<bool>("IsMorning")
                        .HasColumnType("bit");

                    b.Property<int>("PatientAppointmentId")
                        .HasColumnType("int");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PrescribedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("StaffId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PatientAppointmentId");

                    b.ToTable("PatientPrescriptionHistories");
                });

            modelBuilder.Entity("Cloud_Based_ERP_Tool_For_Hospital_BE.Domain.Patients", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BloodGroup")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedOn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedOn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PatientUHID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmailID")
                        .IsUnique();

                    b.HasIndex("MobileNo")
                        .IsUnique();

                    b.HasIndex("PatientUHID")
                        .IsUnique()
                        .HasFilter("[PatientUHID] IS NOT NULL");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("Cloud_Based_ERP_Tool_For_Hospital_BE.Domain.Staffs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepartmentsId")
                        .HasColumnType("int");

                    b.Property<string>("EmailId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsPermanent")
                        .HasColumnType("bit");

                    b.Property<DateTime>("JoiningDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("StaffId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserRoleId")
                        .HasColumnType("int");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentsId");

                    b.HasIndex("UserRoleId");

                    b.ToTable("Staffs");
                });

            modelBuilder.Entity("Cloud_Based_ERP_Tool_For_Hospital_BE.Domain.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RoleDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Cloud_Based_ERP_Tool_For_Hospital_BE.Domain.InPatientDirectory", b =>
                {
                    b.HasOne("Cloud_Based_ERP_Tool_For_Hospital_BE.Domain.Patients", "Patient")
                        .WithMany("InPatientDirectories")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cloud_Based_ERP_Tool_For_Hospital_BE.Domain.Staffs", "Staff")
                        .WithMany("InPatientDirectories")
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("Cloud_Based_ERP_Tool_For_Hospital_BE.Domain.LoginDetails", b =>
                {
                    b.HasOne("Cloud_Based_ERP_Tool_For_Hospital_BE.Domain.Staffs", "Staff")
                        .WithMany()
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("Cloud_Based_ERP_Tool_For_Hospital_BE.Domain.PatientAppointment", b =>
                {
                    b.HasOne("Cloud_Based_ERP_Tool_For_Hospital_BE.Domain.Patients", "Patient")
                        .WithMany("PatientAppointments")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cloud_Based_ERP_Tool_For_Hospital_BE.Domain.Staffs", "Staff")
                        .WithMany("PatientAppointments")
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("Cloud_Based_ERP_Tool_For_Hospital_BE.Domain.PatientPrescriptionHistory", b =>
                {
                    b.HasOne("Cloud_Based_ERP_Tool_For_Hospital_BE.Domain.PatientAppointment", "PatientAppointment")
                        .WithMany("PatientPrescriptionHistories")
                        .HasForeignKey("PatientAppointmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PatientAppointment");
                });

            modelBuilder.Entity("Cloud_Based_ERP_Tool_For_Hospital_BE.Domain.Staffs", b =>
                {
                    b.HasOne("Cloud_Based_ERP_Tool_For_Hospital_BE.Domain.Department", "Departments")
                        .WithMany("Staffs")
                        .HasForeignKey("DepartmentsId")
                        .OnDelete(DeleteBehavior.ClientNoAction)
                        .IsRequired();

                    b.HasOne("Cloud_Based_ERP_Tool_For_Hospital_BE.Domain.UserRole", "UserRole")
                        .WithMany()
                        .HasForeignKey("UserRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departments");

                    b.Navigation("UserRole");
                });

            modelBuilder.Entity("Cloud_Based_ERP_Tool_For_Hospital_BE.Domain.Department", b =>
                {
                    b.Navigation("Staffs");
                });

            modelBuilder.Entity("Cloud_Based_ERP_Tool_For_Hospital_BE.Domain.PatientAppointment", b =>
                {
                    b.Navigation("PatientPrescriptionHistories");
                });

            modelBuilder.Entity("Cloud_Based_ERP_Tool_For_Hospital_BE.Domain.Patients", b =>
                {
                    b.Navigation("InPatientDirectories");

                    b.Navigation("PatientAppointments");
                });

            modelBuilder.Entity("Cloud_Based_ERP_Tool_For_Hospital_BE.Domain.Staffs", b =>
                {
                    b.Navigation("InPatientDirectories");

                    b.Navigation("PatientAppointments");
                });
#pragma warning restore 612, 618
        }
    }
}
