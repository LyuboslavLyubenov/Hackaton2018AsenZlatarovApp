using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HakatonApp.Data.Migrations
{
    public partial class AddImageByteArray2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Quests",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Quests");
        }
    }
}
