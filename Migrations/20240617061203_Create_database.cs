﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NKLBAITHI2324.Migrations
{
    /// <inheritdoc />
    public partial class Create_database : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NKL391Person",
                columns: table => new
                {
                    Ngaysinh = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    HoTen = table.Column<string>(type: "TEXT", nullable: false),
                    DiaChi = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NKL391Person", x => x.Ngaysinh);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NKL391Person");
        }
    }
}
