using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FurioSquad.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BlogViewModelID",
                table: "Tags",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BlogViewModelID1",
                table: "Tags",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ShortDescription",
                table: "Posts",
                maxLength: 300,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 300);

            migrationBuilder.CreateTable(
                name: "BlogViewModel",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    PostedOn = table.Column<DateTime>(nullable: false),
                    Modified = table.Column<DateTime>(nullable: true),
                    PostDislikes = table.Column<int>(nullable: false),
                    PostLikes = table.Column<int>(nullable: false),
                    TotalPosts = table.Column<int>(nullable: false),
                    PostId = table.Column<int>(nullable: true),
                    ShortDescription = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogViewModel", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BlogViewModel_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "PostId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tags_BlogViewModelID",
                table: "Tags",
                column: "BlogViewModelID");

            migrationBuilder.CreateIndex(
                name: "IX_Tags_BlogViewModelID1",
                table: "Tags",
                column: "BlogViewModelID1");

            migrationBuilder.CreateIndex(
                name: "IX_BlogViewModel_PostId",
                table: "BlogViewModel",
                column: "PostId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_BlogViewModel_BlogViewModelID",
                table: "Tags",
                column: "BlogViewModelID",
                principalTable: "BlogViewModel",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_BlogViewModel_BlogViewModelID1",
                table: "Tags",
                column: "BlogViewModelID1",
                principalTable: "BlogViewModel",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tags_BlogViewModel_BlogViewModelID",
                table: "Tags");

            migrationBuilder.DropForeignKey(
                name: "FK_Tags_BlogViewModel_BlogViewModelID1",
                table: "Tags");

            migrationBuilder.DropTable(
                name: "BlogViewModel");

            migrationBuilder.DropIndex(
                name: "IX_Tags_BlogViewModelID",
                table: "Tags");

            migrationBuilder.DropIndex(
                name: "IX_Tags_BlogViewModelID1",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "BlogViewModelID",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "BlogViewModelID1",
                table: "Tags");

            migrationBuilder.AlterColumn<string>(
                name: "ShortDescription",
                table: "Posts",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 300,
                oldNullable: true);
        }
    }
}
