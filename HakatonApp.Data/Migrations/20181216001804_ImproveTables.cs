using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HakatonApp.Data.Migrations
{
    public partial class ImproveTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfQuest",
                table: "Quests",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfQuest",
                table: "Quests");
        }
    }
}
