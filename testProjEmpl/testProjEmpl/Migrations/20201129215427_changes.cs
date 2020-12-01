using Microsoft.EntityFrameworkCore.Migrations;

namespace testProjEmpl.Migrations
{
    public partial class changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "employedDate",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "firedDate",
                table: "Employees");

            migrationBuilder.CreateTable(
                name: "employementHistory",
                columns: table => new
                {
                    Employee_id = table.Column<int>(type: "int", nullable: false),
                    position_id = table.Column<int>(type: "int", nullable: false),
                    idHistory = table.Column<int>(type: "int", nullable: false),
                    from = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    until = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employementHistory", x => new { x.Employee_id, x.position_id });
                    table.ForeignKey(
                        name: "FK_employementHistory_Employees_Employee_id",
                        column: x => x.Employee_id,
                        principalTable: "Employees",
                        principalColumn: "idEmp",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_employementHistory_Positions_position_id",
                        column: x => x.position_id,
                        principalTable: "Positions",
                        principalColumn: "idPosiotion",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_employementHistory_position_id",
                table: "employementHistory",
                column: "position_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employementHistory");

            migrationBuilder.AddColumn<string>(
                name: "employedDate",
                table: "Employees",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "firedDate",
                table: "Employees",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }
    }
}
