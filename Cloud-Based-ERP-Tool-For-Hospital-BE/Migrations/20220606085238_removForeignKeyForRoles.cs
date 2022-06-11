using Microsoft.EntityFrameworkCore.Migrations;

namespace Cloud_Based_ERP_Tool_For_Hospital_BE.Migrations
{
    public partial class removForeignKeyForRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Staffs_UserRoles_UserRoleId",
                table: "Staffs");

            migrationBuilder.DropIndex(
                name: "IX_Staffs_UserRoleId",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "UserRoleId",
                table: "Staffs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserRoleId",
                table: "Staffs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_UserRoleId",
                table: "Staffs",
                column: "UserRoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Staffs_UserRoles_UserRoleId",
                table: "Staffs",
                column: "UserRoleId",
                principalTable: "UserRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
