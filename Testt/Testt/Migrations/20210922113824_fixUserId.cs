using Microsoft.EntityFrameworkCore.Migrations;

namespace Testt.Migrations
{
    public partial class fixUserId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_post_users_UserId",
                table: "post");

            migrationBuilder.DropForeignKey(
                name: "FK_post_users_UserId1",
                table: "post");

            migrationBuilder.DropPrimaryKey(
                name: "PK_post",
                table: "post");

            migrationBuilder.DropIndex(
                name: "IX_post_UserId1",
                table: "post");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "post");

            migrationBuilder.RenameTable(
                name: "post",
                newName: "posts");

            migrationBuilder.RenameIndex(
                name: "IX_post_UserId",
                table: "posts",
                newName: "IX_posts_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_posts",
                table: "posts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_posts_users_UserId",
                table: "posts",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_posts_users_UserId",
                table: "posts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_posts",
                table: "posts");

            migrationBuilder.RenameTable(
                name: "posts",
                newName: "post");

            migrationBuilder.RenameIndex(
                name: "IX_posts_UserId",
                table: "post",
                newName: "IX_post_UserId");

            migrationBuilder.AddColumn<int>(
                name: "UserId1",
                table: "post",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_post",
                table: "post",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_post_UserId1",
                table: "post",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_post_users_UserId",
                table: "post",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_post_users_UserId1",
                table: "post",
                column: "UserId1",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
