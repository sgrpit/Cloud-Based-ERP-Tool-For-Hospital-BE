using Microsoft.EntityFrameworkCore.Migrations;

namespace Cloud_Based_ERP_Tool_For_Hospital_BE.Migrations
{
    public partial class renameForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IPDPatientTreatmentBreakup_InPatientDirectory_InPatientDirectoryId",
                table: "IPDPatientTreatmentBreakup");

            migrationBuilder.DropColumn(
                name: "InPateintDirectoryId",
                table: "IPDPatientTreatmentBreakup");

            migrationBuilder.AlterColumn<int>(
                name: "InPatientDirectoryId",
                table: "IPDPatientTreatmentBreakup",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_IPDPatientTreatmentBreakup_InPatientDirectory_InPatientDirectoryId",
                table: "IPDPatientTreatmentBreakup",
                column: "InPatientDirectoryId",
                principalTable: "InPatientDirectory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IPDPatientTreatmentBreakup_InPatientDirectory_InPatientDirectoryId",
                table: "IPDPatientTreatmentBreakup");

            migrationBuilder.AlterColumn<int>(
                name: "InPatientDirectoryId",
                table: "IPDPatientTreatmentBreakup",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "InPateintDirectoryId",
                table: "IPDPatientTreatmentBreakup",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_IPDPatientTreatmentBreakup_InPatientDirectory_InPatientDirectoryId",
                table: "IPDPatientTreatmentBreakup",
                column: "InPatientDirectoryId",
                principalTable: "InPatientDirectory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
