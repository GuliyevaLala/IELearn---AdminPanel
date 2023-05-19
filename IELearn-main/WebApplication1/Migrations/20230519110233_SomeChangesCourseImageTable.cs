using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IELearn.Migrations
{
    public partial class SomeChangesCourseImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseImages_Courses_CourseId",
                table: "CourseImages");

            migrationBuilder.DropIndex(
                name: "IX_CourseImages_CourseId",
                table: "CourseImages");

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "CourseImages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "CourseCourseImage",
                columns: table => new
                {
                    CourseImagesId = table.Column<int>(type: "int", nullable: false),
                    CoursesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseCourseImage", x => new { x.CourseImagesId, x.CoursesId });
                    table.ForeignKey(
                        name: "FK_CourseCourseImage_CourseImages_CourseImagesId",
                        column: x => x.CourseImagesId,
                        principalTable: "CourseImages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseCourseImage_Courses_CoursesId",
                        column: x => x.CoursesId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseCourseImage_CoursesId",
                table: "CourseCourseImage",
                column: "CoursesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseCourseImage");

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "CourseImages",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_CourseImages_CourseId",
                table: "CourseImages",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseImages_Courses_CourseId",
                table: "CourseImages",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id");
        }
    }
}
