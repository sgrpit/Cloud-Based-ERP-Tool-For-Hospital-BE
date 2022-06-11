using Microsoft.EntityFrameworkCore.Migrations;

namespace Cloud_Based_ERP_Tool_For_Hospital_BE.Migrations
{
    public partial class removeStaffIDFromLogin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LoginDetails_Staffs_StaffId",
                table: "LoginDetails");

            migrationBuilder.DropIndex(
                name: "IX_LoginDetails_StaffId",
                table: "LoginDetails");

            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "LoginDetails");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StaffId",
                table: "LoginDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_LoginDetails_StaffId",
                table: "LoginDetails",
                column: "StaffId");

            migrationBuilder.AddForeignKey(
                name: "FK_LoginDetails_Staffs_StaffId",
                table: "LoginDetails",
                column: "StaffId",
                principalTable: "Staffs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
