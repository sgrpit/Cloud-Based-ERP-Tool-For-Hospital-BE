using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cloud_Based_ERP_Tool_For_Hospital_BE.Migrations
{
    public partial class AddForeignKeyForAppointmentadnprescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InPatientDirectory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    PatientUHID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StaffId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoomType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BedNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsInsured = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsuranceCompany = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdminssionDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DischargeDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DignosisDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DischargeSummary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StaffId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InPatientDirectory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InPatientDirectory_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InPatientDirectory_Staffs_StaffId1",
                        column: x => x.StaffId1,
                        principalTable: "Staffs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PatientPrescriptionHistories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientAppointmentId = table.Column<int>(type: "int", nullable: false),
                    StaffId = table.Column<int>(type: "int", nullable: false),
                    DrugType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DrugName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsBeforeFood = table.Column<bool>(type: "bit", nullable: false),
                    IsMorning = table.Column<bool>(type: "bit", nullable: false),
                    IsAfternoon = table.Column<bool>(type: "bit", nullable: false),
                    IsEvening = table.Column<bool>(type: "bit", nullable: false),
                    PrescribedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientPrescriptionHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PatientPrescriptionHistories_PatientAppointments_PatientAppointmentId",
                        column: x => x.PatientAppointmentId,
                        principalTable: "PatientAppointments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InPatientDirectory_PatientId",
                table: "InPatientDirectory",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_InPatientDirectory_StaffId1",
                table: "InPatientDirectory",
                column: "StaffId1");

            migrationBuilder.CreateIndex(
                name: "IX_PatientPrescriptionHistories_PatientAppointmentId",
                table: "PatientPrescriptionHistories",
                column: "PatientAppointmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InPatientDirectory");

            migrationBuilder.DropTable(
                name: "PatientPrescriptionHistories");
        }
    }
}
