using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProMan_Project.Migrations
{
    /// <inheritdoc />
    public partial class _8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Skill1",
                table: "Home",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Skill2",
                table: "Home",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Skill3",
                table: "Home",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Skill4",
                table: "Home",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Skill5",
                table: "Home",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Skill6",
                table: "Home",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "service1Name",
                table: "Home",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "service1Title",
                table: "Home",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "service1UpTitle",
                table: "Home",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "service2Name",
                table: "Home",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "service2Title",
                table: "Home",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "service2UpTitle",
                table: "Home",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "service3Name",
                table: "Home",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "service3Title",
                table: "Home",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "service3UpTitle",
                table: "Home",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "service4Name",
                table: "Home",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "service4Title",
                table: "Home",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "service4UpTitle",
                table: "Home",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "service5Name",
                table: "Home",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "service5Title",
                table: "Home",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "service5UpTitle",
                table: "Home",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "service6Name",
                table: "Home",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "service6Title",
                table: "Home",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "service6UpTitle",
                table: "Home",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Skill1",
                table: "Home");

            migrationBuilder.DropColumn(
                name: "Skill2",
                table: "Home");

            migrationBuilder.DropColumn(
                name: "Skill3",
                table: "Home");

            migrationBuilder.DropColumn(
                name: "Skill4",
                table: "Home");

            migrationBuilder.DropColumn(
                name: "Skill5",
                table: "Home");

            migrationBuilder.DropColumn(
                name: "Skill6",
                table: "Home");

            migrationBuilder.DropColumn(
                name: "service1Name",
                table: "Home");

            migrationBuilder.DropColumn(
                name: "service1Title",
                table: "Home");

            migrationBuilder.DropColumn(
                name: "service1UpTitle",
                table: "Home");

            migrationBuilder.DropColumn(
                name: "service2Name",
                table: "Home");

            migrationBuilder.DropColumn(
                name: "service2Title",
                table: "Home");

            migrationBuilder.DropColumn(
                name: "service2UpTitle",
                table: "Home");

            migrationBuilder.DropColumn(
                name: "service3Name",
                table: "Home");

            migrationBuilder.DropColumn(
                name: "service3Title",
                table: "Home");

            migrationBuilder.DropColumn(
                name: "service3UpTitle",
                table: "Home");

            migrationBuilder.DropColumn(
                name: "service4Name",
                table: "Home");

            migrationBuilder.DropColumn(
                name: "service4Title",
                table: "Home");

            migrationBuilder.DropColumn(
                name: "service4UpTitle",
                table: "Home");

            migrationBuilder.DropColumn(
                name: "service5Name",
                table: "Home");

            migrationBuilder.DropColumn(
                name: "service5Title",
                table: "Home");

            migrationBuilder.DropColumn(
                name: "service5UpTitle",
                table: "Home");

            migrationBuilder.DropColumn(
                name: "service6Name",
                table: "Home");

            migrationBuilder.DropColumn(
                name: "service6Title",
                table: "Home");

            migrationBuilder.DropColumn(
                name: "service6UpTitle",
                table: "Home");
        }
    }
}
