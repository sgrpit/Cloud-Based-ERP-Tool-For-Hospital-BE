using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cloud_Based_ERP_Tool_For_Hospital_BE.Migrations
{
    public partial class CleanupDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientAppointments_Patients_PatientsId",
                table: "PatientAppointments");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientAppointments_Staffs_StaffId",
                table: "PatientAppointments");

            migrationBuilder.DropTable(
                name: "InPatientDirectory");

            migrationBuilder.DropTable(
                name: "PatientPrescriptionHistories");

            migrationBuilder.DropIndex(
                name: "IX_PatientAppointments_PatientsId",
                table: "PatientAppointments");

            migrationBuilder.DropIndex(
                name: "IX_PatientAppointments_StaffId",
                table: "PatientAppointments");

            migrationBuilder.DropColumn(
                name: "PatientsId",
                table: "PatientAppointments");

            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "PatientAppointments");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PatientsId",
                table: "PatientAppointments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StaffId",
                table: "PatientAppointments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "InPatientDirectory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminssionDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BedNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DignosisDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DischargeDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DischargeSummary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsuranceCompany = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsInsured = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatientUHID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReferredBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoomType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InPatientDirectory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PatientPrescriptionHistories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DrugName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DrugType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsAfternoon = table.Column<bool>(type: "bit", nullable: false),
                    IsBeforeFood = table.Column<bool>(type: "bit", nullable: false),
                    IsEvening = table.Column<bool>(type: "bit", nullable: false),
                    IsMorning = table.Column<bool>(type: "bit", nullable: false),
                    PatientAppointmentId = table.Column<int>(type: "int", nullable: true),
                    PatientsId = table.Column<int>(type: "int", nullable: true),
                    PrescribedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StaffsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientPrescriptionHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PatientPrescriptionHistories_PatientAppointments_PatientAppointmentId",
                        column: x => x.PatientAppointmentId,
                        principalTable: "PatientAppointments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientPrescriptionHistories_Patients_PatientsId",
                        column: x => x.PatientsId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientPrescriptionHistories_Staffs_StaffsId",
                        column: x => x.StaffsId,
                        principalTable: "Staffs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PatientAppointments_PatientsId",
                table: "PatientAppointments",
                column: "PatientsId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientAppointments_StaffId",
                table: "PatientAppointments",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientPrescriptionHistories_PatientAppointmentId",
                table: "PatientPrescriptionHistories",
                column: "PatientAppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientPrescriptionHistories_PatientsId",
                table: "PatientPrescriptionHistories",
                column: "PatientsId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientPrescriptionHistories_StaffsId",
                table: "PatientPrescriptionHistories",
                column: "StaffsId");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAppointments_Patients_PatientsId",
                table: "PatientAppointments",
                column: "PatientsId",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAppointments_Staffs_StaffId",
                table: "PatientAppointments",
                column: "StaffId",
                principalTable: "Staffs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
