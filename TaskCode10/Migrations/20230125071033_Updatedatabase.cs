using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskCode10.Migrations
{
    /// <inheritdoc />
    public partial class Updatedatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Pozitions_PozitionId",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "PozitionId",
                table: "Employees",
                newName: "PozisionId");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_PozitionId",
                table: "Employees",
                newName: "IX_Employees_PozisionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Pozitions_PozisionId",
                table: "Employees",
                column: "PozisionId",
                principalTable: "Pozitions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Pozitions_PozisionId",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "PozisionId",
                table: "Employees",
                newName: "PozitionId");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_PozisionId",
                table: "Employees",
                newName: "IX_Employees_PozitionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Pozitions_PozitionId",
                table: "Employees",
                column: "PozitionId",
                principalTable: "Pozitions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
