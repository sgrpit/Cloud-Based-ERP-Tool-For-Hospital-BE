using Microsoft.EntityFrameworkCore.Migrations;

namespace Cloud_Based_ERP_Tool_For_Hospital_BE.Migrations
{
    public partial class AlterTablePatietnPrescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DrugConsumtionScehdule",
                table: "PatientPrescriptionHistories");

            migrationBuilder.AddColumn<bool>(
                name: "IsAfternoon",
                table: "PatientPrescriptionHistories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsBeforeFood",
                table: "PatientPrescriptionHistories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsEvening",
                table: "PatientPrescriptionHistories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsMorning",
                table: "PatientPrescriptionHistories",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAfternoon",
                table: "PatientPrescriptionHistories");

            migrationBuilder.DropColumn(
                name: "IsBeforeFood",
                table: "PatientPrescriptionHistories");

            migrationBuilder.DropColumn(
                name: "IsEvening",
                table: "PatientPrescriptionHistories");

            migrationBuilder.DropColumn(
                name: "IsMorning",
                table: "PatientPrescriptionHistories");

            migrationBuilder.AddColumn<string>(
                name: "DrugConsumtionScehdule",
                table: "PatientPrescriptionHistories",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
