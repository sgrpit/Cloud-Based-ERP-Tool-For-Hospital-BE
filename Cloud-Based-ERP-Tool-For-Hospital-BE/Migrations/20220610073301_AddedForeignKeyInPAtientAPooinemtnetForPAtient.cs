using Microsoft.EntityFrameworkCore.Migrations;

namespace Cloud_Based_ERP_Tool_For_Hospital_BE.Migrations
{
    public partial class AddedForeignKeyInPAtientAPooinemtnetForPAtient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PatientId",
                table: "PatientAppointments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PatientsId",
                table: "PatientAppointments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PatientAppointments_PatientsId",
                table: "PatientAppointments",
                column: "PatientsId");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAppointments_Patients_PatientsId",
                table: "PatientAppointments",
                column: "PatientsId",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientAppointments_Patients_PatientsId",
                table: "PatientAppointments");

            migrationBuilder.DropIndex(
                name: "IX_PatientAppointments_PatientsId",
                table: "PatientAppointments");

            migrationBuilder.DropColumn(
                name: "PatientsId",
                table: "PatientAppointments");

            migrationBuilder.AlterColumn<string>(
                name: "PatientId",
                table: "PatientAppointments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
