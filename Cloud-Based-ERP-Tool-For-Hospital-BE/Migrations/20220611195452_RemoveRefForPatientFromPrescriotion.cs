using Microsoft.EntityFrameworkCore.Migrations;

namespace Cloud_Based_ERP_Tool_For_Hospital_BE.Migrations
{
    public partial class RemoveRefForPatientFromPrescriotion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientPrescriptionHistories_Patients_PatientId",
                table: "PatientPrescriptionHistories");

            migrationBuilder.DropIndex(
                name: "IX_PatientPrescriptionHistories_PatientId",
                table: "PatientPrescriptionHistories");

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "PatientPrescriptionHistories");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PatientId",
                table: "PatientPrescriptionHistories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PatientPrescriptionHistories_PatientId",
                table: "PatientPrescriptionHistories",
                column: "PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientPrescriptionHistories_Patients_PatientId",
                table: "PatientPrescriptionHistories",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
