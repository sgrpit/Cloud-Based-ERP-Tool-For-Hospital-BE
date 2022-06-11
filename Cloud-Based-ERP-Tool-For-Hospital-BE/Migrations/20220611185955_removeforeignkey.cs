using Microsoft.EntityFrameworkCore.Migrations;

namespace Cloud_Based_ERP_Tool_For_Hospital_BE.Migrations
{
    public partial class removeforeignkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InPatientDirectory_Staffs_StaffId",
                table: "InPatientDirectory");

            migrationBuilder.RenameColumn(
                name: "StaffId",
                table: "InPatientDirectory",
                newName: "StaffsId");

            migrationBuilder.RenameIndex(
                name: "IX_InPatientDirectory_StaffId",
                table: "InPatientDirectory",
                newName: "IX_InPatientDirectory_StaffsId");

            migrationBuilder.AddForeignKey(
                name: "FK_InPatientDirectory_Staffs_StaffsId",
                table: "InPatientDirectory",
                column: "StaffsId",
                principalTable: "Staffs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InPatientDirectory_Staffs_StaffsId",
                table: "InPatientDirectory");

            migrationBuilder.RenameColumn(
                name: "StaffsId",
                table: "InPatientDirectory",
                newName: "StaffId");

            migrationBuilder.RenameIndex(
                name: "IX_InPatientDirectory_StaffsId",
                table: "InPatientDirectory",
                newName: "IX_InPatientDirectory_StaffId");

            migrationBuilder.AddForeignKey(
                name: "FK_InPatientDirectory_Staffs_StaffId",
                table: "InPatientDirectory",
                column: "StaffId",
                principalTable: "Staffs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
