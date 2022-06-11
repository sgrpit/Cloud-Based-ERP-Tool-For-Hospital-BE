using Microsoft.EntityFrameworkCore.Migrations;

namespace Cloud_Based_ERP_Tool_For_Hospital_BE.Migrations
{
    public partial class RemovedUnWantedColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AppointmentId",
                table: "PatientPrescriptionHistories");

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "PatientPrescriptionHistories");

            migrationBuilder.DropColumn(
                name: "PrescribedBy",
                table: "PatientPrescriptionHistories");

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "PatientAppointments");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppointmentId",
                table: "PatientPrescriptionHistories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PatientId",
                table: "PatientPrescriptionHistories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PrescribedBy",
                table: "PatientPrescriptionHistories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PatientId",
                table: "PatientAppointments",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
