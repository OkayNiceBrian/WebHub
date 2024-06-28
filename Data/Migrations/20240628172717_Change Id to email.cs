using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebHub.Data.Migrations
{
    public partial class ChangeIdtoemail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "BlogPost");

            migrationBuilder.AddColumn<string>(
                name: "UserEmail",
                table: "BlogPost",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserEmail",
                table: "BlogPost");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "BlogPost",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
