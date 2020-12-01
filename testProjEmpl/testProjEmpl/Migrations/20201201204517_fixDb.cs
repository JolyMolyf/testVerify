using Microsoft.EntityFrameworkCore.Migrations;

namespace testProjEmpl.Migrations
{
    public partial class fixDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tests");

            migrationBuilder.DropColumn(
                name: "idHistory",
                table: "employementHistory");

            migrationBuilder.RenameColumn(
                name: "from",
                table: "employementHistory",
                newName: "From");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "From",
                table: "employementHistory",
                newName: "from");

            migrationBuilder.AddColumn<int>(
                name: "idHistory",
                table: "employementHistory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Tests",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<int>(type: "int", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Note_PK", x => x.id);
                });
        }
    }
}
