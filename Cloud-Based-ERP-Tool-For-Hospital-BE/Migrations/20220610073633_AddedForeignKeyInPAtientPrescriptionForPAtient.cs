using Microsoft.EntityFrameworkCore.Migrations;

namespace Cloud_Based_ERP_Tool_For_Hospital_BE.Migrations
{
    public partial class AddedForeignKeyInPAtientPrescriptionForPAtient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PatientsId",
                table: "PatientPrescriptionHistories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PatientPrescriptionHistories_PatientsId",
                table: "PatientPrescriptionHistories",
                column: "PatientsId");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientPrescriptionHistories_Patients_PatientsId",
                table: "PatientPrescriptionHistories",
                column: "PatientsId",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientPrescriptionHistories_Patients_PatientsId",
                table: "PatientPrescriptionHistories");

            migrationBuilder.DropIndex(
                name: "IX_PatientPrescriptionHistories_PatientsId",
                table: "PatientPrescriptionHistories");

            migrationBuilder.DropColumn(
                name: "PatientsId",
                table: "PatientPrescriptionHistories");
        }
    }
}
