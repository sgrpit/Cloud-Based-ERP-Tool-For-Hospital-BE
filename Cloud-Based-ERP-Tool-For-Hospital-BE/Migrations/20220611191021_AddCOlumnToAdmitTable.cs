using Microsoft.EntityFrameworkCore.Migrations;

namespace Cloud_Based_ERP_Tool_For_Hospital_BE.Migrations
{
    public partial class AddCOlumnToAdmitTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DignosisDetails",
                table: "InPatientDirectory");

            migrationBuilder.AddColumn<bool>(
                name: "IsDischarged",
                table: "InPatientDirectory",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDischarged",
                table: "InPatientDirectory");

            migrationBuilder.AddColumn<string>(
                name: "DignosisDetails",
                table: "InPatientDirectory",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
