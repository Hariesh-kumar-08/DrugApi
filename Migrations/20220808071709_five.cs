using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DrugApi.Migrations
{
    public partial class five : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "admins",
                newName: "AdminId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AdminId",
                table: "admins",
                newName: "Id");
        }
    }
}
