using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_SESSION_1_DEMO.Migrations
{
    public partial class _4create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "employee",
                schema: "dbo",
                columns: table => new
                {
                    EmpId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, defaultValue: "Fady"),
                    Salary = table.Column<decimal>(type: "money", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: true),
                    phone = table.Column<int>(type: "int", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Totalsalary = table.Column<double>(type: "float", nullable: false),
                    num = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employee", x => x.EmpId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employee",
                schema: "dbo");
        }
    }
}
