using Microsoft.EntityFrameworkCore.Migrations;

namespace Cloud_Based_ERP_Tool_For_Hospital_BE.Migrations
{
    public partial class remvoeduplicatecolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InPatientDirectory_Staffs_StaffId1",
                table: "InPatientDirectory");

            migrationBuilder.DropIndex(
                name: "IX_InPatientDirectory_StaffId1",
                table: "InPatientDirectory");

            migrationBuilder.DropColumn(
                name: "StaffId1",
                table: "InPatientDirectory");

            migrationBuilder.AlterColumn<int>(
                name: "StaffId",
                table: "InPatientDirectory",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InPatientDirectory_Staffs_StaffId",
                table: "InPatientDirectory");

            migrationBuilder.DropIndex(
                name: "IX_InPatientDirectory_StaffId",
                table: "InPatientDirectory");

            migrationBuilder.AlterColumn<string>(
                name: "StaffId",
                table: "InPatientDirectory",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StaffId1",
                table: "InPatientDirectory",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_InPatientDirectory_StaffId1",
                table: "InPatientDirectory",
                column: "StaffId1");

            migrationBuilder.AddForeignKey(
                name: "FK_InPatientDirectory_Staffs_StaffId1",
                table: "InPatientDirectory",
                column: "StaffId1",
                principalTable: "Staffs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
