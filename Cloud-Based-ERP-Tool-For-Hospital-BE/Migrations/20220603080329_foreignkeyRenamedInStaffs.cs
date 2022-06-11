using Microsoft.EntityFrameworkCore.Migrations;

namespace Cloud_Based_ERP_Tool_For_Hospital_BE.Migrations
{
    public partial class foreignkeyRenamedInStaffs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Staffs_Departments_DepartmentId",
                table: "Staffs");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "Staffs",
                newName: "DepartmentsId");

            migrationBuilder.RenameIndex(
                name: "IX_Staffs_DepartmentId",
                table: "Staffs",
                newName: "IX_Staffs_DepartmentsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Staffs_Departments_DepartmentsId",
                table: "Staffs",
                column: "DepartmentsId",
                principalTable: "Departments",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Staffs_Departments_DepartmentsId",
                table: "Staffs");

            migrationBuilder.RenameColumn(
                name: "DepartmentsId",
                table: "Staffs",
                newName: "DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Staffs_DepartmentsId",
                table: "Staffs",
                newName: "IX_Staffs_DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Staffs_Departments_DepartmentId",
                table: "Staffs",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id");
        }
    }
}
