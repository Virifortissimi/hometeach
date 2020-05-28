using Microsoft.EntityFrameworkCore.Migrations;

namespace eagle_hometeach.src.Migrations.TeacherDb
{
    public partial class ThirdCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "YearsOfExperience",
                table: "TeacherDetails",
                maxLength: 3,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AddColumn<string>(
                name: "PictureLink",
                table: "TeacherDetails",
                maxLength: 30,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PictureLink",
                table: "TeacherDetails");

            migrationBuilder.AlterColumn<string>(
                name: "YearsOfExperience",
                table: "TeacherDetails",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 3);
        }
    }
}
