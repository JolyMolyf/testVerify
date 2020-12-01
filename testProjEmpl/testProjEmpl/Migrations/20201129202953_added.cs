using Microsoft.EntityFrameworkCore.Migrations;

namespace testProjEmpl.Migrations
{
    public partial class added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    idEmp = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    payment = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    employedDate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    firedDate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Employee_Pk", x => x.idEmp);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    idPosiotion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Position_Pk", x => x.idPosiotion);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Positions");
        }
    }
}
