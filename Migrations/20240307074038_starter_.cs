﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace auth_102.Migrations
{
    /// <inheritdoc />
    public partial class starter_ : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fullname",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "u_Roles",
                table: "AspNetUsers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Fullname",
                table: "AspNetUsers",
                type: "longtext",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "u_Roles",
                table: "AspNetUsers",
                type: "longtext",
                nullable: false);
        }
    }
}
