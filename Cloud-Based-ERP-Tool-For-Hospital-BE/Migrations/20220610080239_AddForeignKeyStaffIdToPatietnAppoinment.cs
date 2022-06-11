using Microsoft.EntityFrameworkCore.Migrations;

namespace Cloud_Based_ERP_Tool_For_Hospital_BE.Migrations
{
    public partial class AddForeignKeyStaffIdToPatietnAppoinment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StaffId",
                table: "PatientAppointments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PatientAppointments_StaffId",
                table: "PatientAppointments",
                column: "StaffId");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAppointments_Staffs_StaffId",
                table: "PatientAppointments",
                column: "StaffId",
                principalTable: "Staffs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientAppointments_Staffs_StaffId",
                table: "PatientAppointments");

            migrationBuilder.DropIndex(
                name: "IX_PatientAppointments_StaffId",
                table: "PatientAppointments");

            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "PatientAppointments");
        }
    }
}
