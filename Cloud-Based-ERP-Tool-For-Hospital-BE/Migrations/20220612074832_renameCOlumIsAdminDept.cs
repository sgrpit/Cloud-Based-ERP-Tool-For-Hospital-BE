using Microsoft.EntityFrameworkCore.Migrations;

namespace Cloud_Based_ERP_Tool_For_Hospital_BE.Migrations
{
    public partial class renameCOlumIsAdminDept : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsAdminDeaprtment",
                table: "Departments",
                newName: "IsAdminDepartment");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsAdminDepartment",
                table: "Departments",
                newName: "IsAdminDeaprtment");
        }
    }
}
