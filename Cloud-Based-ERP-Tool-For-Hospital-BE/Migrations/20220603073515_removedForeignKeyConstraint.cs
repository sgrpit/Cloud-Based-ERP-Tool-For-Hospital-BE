using Microsoft.EntityFrameworkCore.Migrations;

namespace Cloud_Based_ERP_Tool_For_Hospital_BE.Migrations
{
    public partial class removedForeignKeyConstraint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Staffs_Departments_DepartmentsId",
                table: "Staffs");

            migrationBuilder.DropIndex(
                name: "IX_Staffs_DepartmentsId",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "DepartmentsId",
                table: "Staffs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentsId",
                table: "Staffs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_DepartmentsId",
                table: "Staffs",
                column: "DepartmentsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Staffs_Departments_DepartmentsId",
                table: "Staffs",
                column: "DepartmentsId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
