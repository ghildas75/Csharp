using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MusicStore.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Albums_Artist_ArtistId",
                table: "Albums");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Artist",
                table: "Artist");

            migrationBuilder.RenameTable(
                name: "Artist",
                newName: "Artises");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Artises",
                table: "Artises",
                column: "ArtistId");

            migrationBuilder.AddForeignKey(
                name: "FK_Albums_Artises_ArtistId",
                table: "Albums",
                column: "ArtistId",
                principalTable: "Artises",
                principalColumn: "ArtistId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Albums_Artises_ArtistId",
                table: "Albums");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Artises",
                table: "Artises");

            migrationBuilder.RenameTable(
                name: "Artises",
                newName: "Artist");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Artist",
                table: "Artist",
                column: "ArtistId");

            migrationBuilder.AddForeignKey(
                name: "FK_Albums_Artist_ArtistId",
                table: "Albums",
                column: "ArtistId",
                principalTable: "Artist",
                principalColumn: "ArtistId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
