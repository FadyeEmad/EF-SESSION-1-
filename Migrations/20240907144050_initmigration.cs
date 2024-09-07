using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_SESSION_1_DEMO.Migrations
{
    public partial class initmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "num",
                schema: "dbo",
                table: "employee",
                newName: "num2");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "dbo",
                table: "employee",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValue: "Fady");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "num2",
                schema: "dbo",
                table: "employee",
                newName: "num");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "dbo",
                table: "employee",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValue: "Fady",
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50,
                oldNullable: true);
        }
    }
}
