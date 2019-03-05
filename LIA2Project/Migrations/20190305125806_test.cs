using Microsoft.EntityFrameworkCore.Migrations;

namespace LIA2Project.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Users",
                newName: "UserAuthPassword");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserAuthPassword",
                table: "Users",
                newName: "Password");
        }
    }
}
