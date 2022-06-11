using Microsoft.EntityFrameworkCore.Migrations;

namespace Cloud_Based_ERP_Tool_For_Hospital_BE.Migrations
{
    public partial class removeforeignkeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InPatientDirectory_Staffs_StaffsId",
                table: "InPatientDirectory");

            migrationBuilder.DropIndex(
                name: "IX_InPatientDirectory_StaffsId",
                table: "InPatientDirectory");

            migrationBuilder.DropColumn(
                name: "StaffsId",
                table: "InPatientDirectory");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StaffsId",
                table: "InPatientDirectory",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_InPatientDirectory_StaffsId",
                table: "InPatientDirectory",
                column: "StaffsId");

            migrationBuilder.AddForeignKey(
                name: "FK_InPatientDirectory_Staffs_StaffsId",
                table: "InPatientDirectory",
                column: "StaffsId",
                principalTable: "Staffs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
