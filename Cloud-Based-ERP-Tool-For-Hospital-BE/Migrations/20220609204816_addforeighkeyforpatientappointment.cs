using Microsoft.EntityFrameworkCore.Migrations;

namespace Cloud_Based_ERP_Tool_For_Hospital_BE.Migrations
{
    public partial class addforeighkeyforpatientappointment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PatientUHID",
                table: "PatientPrescriptionHistories",
                newName: "AppointmentId");

            migrationBuilder.AddColumn<int>(
                name: "PatientAppointmentId",
                table: "PatientPrescriptionHistories",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsCancelled",
                table: "PatientAppointments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsCompleted",
                table: "PatientAppointments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_PatientPrescriptionHistories_PatientAppointmentId",
                table: "PatientPrescriptionHistories",
                column: "PatientAppointmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientPrescriptionHistories_PatientAppointments_PatientAppointmentId",
                table: "PatientPrescriptionHistories",
                column: "PatientAppointmentId",
                principalTable: "PatientAppointments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientPrescriptionHistories_PatientAppointments_PatientAppointmentId",
                table: "PatientPrescriptionHistories");

            migrationBuilder.DropIndex(
                name: "IX_PatientPrescriptionHistories_PatientAppointmentId",
                table: "PatientPrescriptionHistories");

            migrationBuilder.DropColumn(
                name: "PatientAppointmentId",
                table: "PatientPrescriptionHistories");

            migrationBuilder.DropColumn(
                name: "IsCancelled",
                table: "PatientAppointments");

            migrationBuilder.DropColumn(
                name: "IsCompleted",
                table: "PatientAppointments");

            migrationBuilder.RenameColumn(
                name: "AppointmentId",
                table: "PatientPrescriptionHistories",
                newName: "PatientUHID");
        }
    }
}
