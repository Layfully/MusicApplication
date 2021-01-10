using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicApplication.Migrations
{
    public partial class addpictureofalbum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Picture",
                table: "Albums",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Picture",
                table: "Albums");
        }
    }
}
