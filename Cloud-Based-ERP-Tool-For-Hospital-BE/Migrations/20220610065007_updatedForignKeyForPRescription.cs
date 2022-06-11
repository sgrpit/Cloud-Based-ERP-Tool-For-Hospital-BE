using Microsoft.EntityFrameworkCore.Migrations;

namespace Cloud_Based_ERP_Tool_For_Hospital_BE.Migrations
{
    public partial class updatedForignKeyForPRescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StaffsId",
                table: "PatientPrescriptionHistories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PatientPrescriptionHistories_StaffsId",
                table: "PatientPrescriptionHistories",
                column: "StaffsId");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientPrescriptionHistories_Staffs_StaffsId",
                table: "PatientPrescriptionHistories",
                column: "StaffsId",
                principalTable: "Staffs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientPrescriptionHistories_Staffs_StaffsId",
                table: "PatientPrescriptionHistories");

            migrationBuilder.DropIndex(
                name: "IX_PatientPrescriptionHistories_StaffsId",
                table: "PatientPrescriptionHistories");

            migrationBuilder.DropColumn(
                name: "StaffsId",
                table: "PatientPrescriptionHistories");
        }
    }
}
