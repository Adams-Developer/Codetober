using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ContosoUniversityApplication.Migrations
{
    public partial class ComplexDataModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Courses_CourseId",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Students_StudentId",
                table: "Enrollments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Enrollments",
                table: "Enrollments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Courses",
                table: "Courses");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "Student");

            migrationBuilder.RenameTable(
                name: "Enrollments",
                newName: "Enrollment");

            migrationBuilder.RenameTable(
                name: "Courses",
                newName: "Course");

            migrationBuilder.RenameIndex(
                name: "IX_Enrollments_StudentId",
                table: "Enrollment",
                newName: "IX_Enrollment_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Enrollments_CourseId",
                table: "Enrollment",
                newName: "IX_Enrollment_CourseId");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Student",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Student",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Course",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Course",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student",
                table: "Student",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Enrollment",
                table: "Enrollment",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course",
                table: "Course",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Instructor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    HireDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CourseAssignment",
                columns: table => new
                {
                    InstructorId = table.Column<int>(nullable: false),
                    CourseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseAssignment", x => new { x.CourseId, x.InstructorId });
                    table.ForeignKey(
                        name: "FK_CourseAssignment_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseAssignment_Instructor_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Instructor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    Budget = table.Column<decimal>(type: "Money", nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    InstructorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.DepartmentId);
                    table.ForeignKey(
                        name: "FK_Department_Instructor_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Instructor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OfficeAssignment",
                columns: table => new
                {
                    InstructorID = table.Column<int>(nullable: false),
                    Location = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfficeAssignment", x => x.InstructorID);
                    table.ForeignKey(
                        name: "FK_OfficeAssignment_Instructor_InstructorID",
                        column: x => x.InstructorID,
                        principalTable: "Instructor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Course_DepartmentId",
                table: "Course",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseAssignment_InstructorId",
                table: "CourseAssignment",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_Department_InstructorId",
                table: "Department",
                column: "InstructorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Department_DepartmentId",
                table: "Course",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollment_Course_CourseId",
                table: "Enrollment",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollment_Student_StudentId",
                table: "Enrollment",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Department_DepartmentId",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollment_Course_CourseId",
                table: "Enrollment");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollment_Student_StudentId",
                table: "Enrollment");

            migrationBuilder.DropTable(
                name: "CourseAssignment");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "OfficeAssignment");

            migrationBuilder.DropTable(
                name: "Instructor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Student",
                table: "Student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Enrollment",
                table: "Enrollment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course",
                table: "Course");

            migrationBuilder.DropIndex(
                name: "IX_Course_DepartmentId",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Course");

            migrationBuilder.RenameTable(
                name: "Student",
                newName: "Students");

            migrationBuilder.RenameTable(
                name: "Enrollment",
                newName: "Enrollments");

            migrationBuilder.RenameTable(
                name: "Course",
                newName: "Courses");

            migrationBuilder.RenameIndex(
                name: "IX_Enrollment_StudentId",
                table: "Enrollments",
                newName: "IX_Enrollments_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Enrollment_CourseId",
                table: "Enrollments",
                newName: "IX_Enrollments_CourseId");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Students",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Students",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Enrollments",
                table: "Enrollments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Courses",
                table: "Courses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Courses_CourseId",
                table: "Enrollments",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Students_StudentId",
                table: "Enrollments",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
