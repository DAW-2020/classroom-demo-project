using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAW.Migrations
{
    public partial class AddedCourseStudentAsBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTime",
                table: "CourseStudents",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "CourseStudents",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedTime",
                table: "CourseStudents",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateTime",
                table: "CourseStudents");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "CourseStudents");

            migrationBuilder.DropColumn(
                name: "UpdatedTime",
                table: "CourseStudents");
        }
    }
}
