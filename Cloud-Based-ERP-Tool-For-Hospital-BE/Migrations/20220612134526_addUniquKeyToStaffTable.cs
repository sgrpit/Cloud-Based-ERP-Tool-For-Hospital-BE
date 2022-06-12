using Microsoft.EntityFrameworkCore.Migrations;

namespace Cloud_Based_ERP_Tool_For_Hospital_BE.Migrations
{
    public partial class addUniquKeyToStaffTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MobileNo",
                table: "Staffs",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "EmailId",
                table: "Staffs",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_EmailId",
                table: "Staffs",
                column: "EmailId",
                unique: true,
                filter: "[EmailId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_MobileNo",
                table: "Staffs",
                column: "MobileNo",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Staffs_EmailId",
                table: "Staffs");

            migrationBuilder.DropIndex(
                name: "IX_Staffs_MobileNo",
                table: "Staffs");

            migrationBuilder.AlterColumn<string>(
                name: "MobileNo",
                table: "Staffs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "EmailId",
                table: "Staffs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);
        }
    }
}
