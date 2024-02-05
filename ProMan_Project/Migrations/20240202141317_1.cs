using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProMan_Project.Migrations
{
    /// <inheritdoc />
    public partial class _1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Home",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Skills = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearsCount = table.Column<int>(type: "int", nullable: false),
                    OfWorkingExperienceAs_Skills = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutUpTitle = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Feature1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Feature2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Feature3 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Image1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image1Title = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Image1Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image1UpTitle = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Image2Title = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Image2Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image2UpTitle = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Home", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Home");
        }
    }
}
