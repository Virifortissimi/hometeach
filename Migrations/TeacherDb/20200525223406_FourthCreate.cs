using Microsoft.EntityFrameworkCore.Migrations;

namespace eagle_hometeach.src.Migrations.TeacherDb
{
    public partial class FourthCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "TeacherDetails",
                maxLength: 14,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Phone",
                table: "TeacherDetails");
        }
    }
}
