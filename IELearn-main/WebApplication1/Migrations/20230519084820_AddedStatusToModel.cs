using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IELearn.Migrations
{
    public partial class AddedStatusToModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Courses",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Courses");
        }
    }
}
