using Microsoft.EntityFrameworkCore.Migrations;

namespace testProjEmpl.Migrations
{
    public partial class ne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Test",
                newName: "Tests");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Tests",
                newName: "Test");
        }
    }
}
