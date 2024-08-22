using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotNet_MVC.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Courses_CourseId",
                table: "Student");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourse_Courses_CourseId",
                table: "StudentCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourse_Student_StudentId",
                table: "StudentCourse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentCourse",
                table: "StudentCourse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Student",
                table: "Student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Courses",
                table: "Courses");

            migrationBuilder.RenameTable(
                name: "StudentCourse",
                newName: "StudentCourse_Table");

            migrationBuilder.RenameTable(
                name: "Student",
                newName: "Student_Table");

            migrationBuilder.RenameTable(
                name: "Courses",
                newName: "Course_Table");

            migrationBuilder.RenameIndex(
                name: "IX_StudentCourse_StudentId",
                table: "StudentCourse_Table",
                newName: "IX_StudentCourse_Table_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentCourse_CourseId",
                table: "StudentCourse_Table",
                newName: "IX_StudentCourse_Table_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_Student_CourseId",
                table: "Student_Table",
                newName: "IX_Student_Table_CourseId");

            migrationBuilder.AddColumn<int>(
                name: "Emrollment",
                table: "StudentCourse_Table",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentCourse_Table",
                table: "StudentCourse_Table",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student_Table",
                table: "Student_Table",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course_Table",
                table: "Course_Table",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Table_Course_Table_CourseId",
                table: "Student_Table",
                column: "CourseId",
                principalTable: "Course_Table",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourse_Table_Course_Table_CourseId",
                table: "StudentCourse_Table",
                column: "CourseId",
                principalTable: "Course_Table",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourse_Table_Student_Table_StudentId",
                table: "StudentCourse_Table",
                column: "StudentId",
                principalTable: "Student_Table",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Table_Course_Table_CourseId",
                table: "Student_Table");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourse_Table_Course_Table_CourseId",
                table: "StudentCourse_Table");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourse_Table_Student_Table_StudentId",
                table: "StudentCourse_Table");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentCourse_Table",
                table: "StudentCourse_Table");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Student_Table",
                table: "Student_Table");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course_Table",
                table: "Course_Table");

            migrationBuilder.DropColumn(
                name: "Emrollment",
                table: "StudentCourse_Table");

            migrationBuilder.RenameTable(
                name: "StudentCourse_Table",
                newName: "StudentCourse");

            migrationBuilder.RenameTable(
                name: "Student_Table",
                newName: "Student");

            migrationBuilder.RenameTable(
                name: "Course_Table",
                newName: "Courses");

            migrationBuilder.RenameIndex(
                name: "IX_StudentCourse_Table_StudentId",
                table: "StudentCourse",
                newName: "IX_StudentCourse_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentCourse_Table_CourseId",
                table: "StudentCourse",
                newName: "IX_StudentCourse_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_Student_Table_CourseId",
                table: "Student",
                newName: "IX_Student_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentCourse",
                table: "StudentCourse",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student",
                table: "Student",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Courses",
                table: "Courses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Courses_CourseId",
                table: "Student",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourse_Courses_CourseId",
                table: "StudentCourse",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourse_Student_StudentId",
                table: "StudentCourse",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
