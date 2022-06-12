using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cloud_Based_ERP_Tool_For_Hospital_BE.Migrations
{
    public partial class AddTableIPDPatientTreatmentBreakup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IPDPatientTreatmentBreakup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InPateintDirectoryId = table.Column<int>(type: "int", nullable: false),
                    TreatmentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TreatmentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TreatmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    TreatmentAmount = table.Column<double>(type: "float", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InPatientDirectoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IPDPatientTreatmentBreakup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IPDPatientTreatmentBreakup_InPatientDirectory_InPatientDirectoryId",
                        column: x => x.InPatientDirectoryId,
                        principalTable: "InPatientDirectory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IPDPatientTreatmentBreakup_InPatientDirectoryId",
                table: "IPDPatientTreatmentBreakup",
                column: "InPatientDirectoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IPDPatientTreatmentBreakup");
        }
    }
}
