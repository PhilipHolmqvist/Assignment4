﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BJGameDAL.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    playerId = table.Column<int>(type: "int", nullable: false),
                    isFinished = table.Column<bool>(type: "bit", nullable: false),
                    winner = table.Column<bool>(type: "bit", nullable: false),
                    playerName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Hands",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    score = table.Column<int>(type: "int", nullable: false),
                    isBust = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hands", x => x.id);
                    table.ForeignKey(
                        name: "FK_Hands_Players_id",
                        column: x => x.id,
                        principalTable: "Players",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hands");

            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}
