using Microsoft.EntityFrameworkCore.Migrations;

namespace Cloud_Based_ERP_Tool_For_Hospital_BE.Migrations
{
    public partial class StaftableColumnRenamed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "o",
                table: "Staffs");

            migrationBuilder.RenameColumn(
                name: "IsPermananet",
                table: "Staffs",
                newName: "IsPermanent");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsPermanent",
                table: "Staffs",
                newName: "IsPermananet");

            migrationBuilder.AddColumn<int>(
                name: "o",
                table: "Staffs",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
