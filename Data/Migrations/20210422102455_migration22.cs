using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDoList.Data.Migrations
{
    public partial class migration22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ToDoTable",
                table: "ToDoTable");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "ToDoTable",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ToDoTable",
                table: "ToDoTable",
                column: "Title");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ToDoTable",
                table: "ToDoTable");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "ToDoTable",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddPrimaryKey(
                name: "PK_ToDoTable",
                table: "ToDoTable",
                column: "Email");
        }
    }
}
