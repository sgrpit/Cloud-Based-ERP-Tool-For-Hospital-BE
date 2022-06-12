using Microsoft.EntityFrameworkCore.Migrations;

namespace Cloud_Based_ERP_Tool_For_Hospital_BE.Migrations
{
    public partial class addcolumntodepartment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAdminDeaprtment",
                table: "Departments",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAdminDeaprtment",
                table: "Departments");
        }
    }
}
