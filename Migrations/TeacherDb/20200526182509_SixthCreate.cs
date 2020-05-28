using Microsoft.EntityFrameworkCore.Migrations;

namespace eagle_hometeach.src.Migrations.TeacherDb
{
    public partial class SixthCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "TeacherDetails",
                maxLength: 20,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "State",
                table: "TeacherDetails");
        }
    }
}
