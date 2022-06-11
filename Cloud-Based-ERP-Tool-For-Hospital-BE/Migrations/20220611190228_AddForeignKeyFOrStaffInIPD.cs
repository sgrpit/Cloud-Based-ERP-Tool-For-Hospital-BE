using Microsoft.EntityFrameworkCore.Migrations;

namespace Cloud_Based_ERP_Tool_For_Hospital_BE.Migrations
{
    public partial class AddForeignKeyFOrStaffInIPD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StaffId",
                table: "InPatientDirectory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_InPatientDirectory_StaffId",
                table: "InPatientDirectory",
                column: "StaffId");

            migrationBuilder.AddForeignKey(
                name: "FK_InPatientDirectory_Staffs_StaffId",
                table: "InPatientDirectory",
                column: "StaffId",
                principalTable: "Staffs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InPatientDirectory_Staffs_StaffId",
                table: "InPatientDirectory");

            migrationBuilder.DropIndex(
                name: "IX_InPatientDirectory_StaffId",
                table: "InPatientDirectory");

            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "InPatientDirectory");
        }
    }
}
