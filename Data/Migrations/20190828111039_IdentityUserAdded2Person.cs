using Microsoft.EntityFrameworkCore.Migrations;

namespace HockeyPlanner2019.Data.Migrations
{
    public partial class IdentityUserAdded2Person : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IdentityUserId",
                table: "Person",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Person_IdentityUserId",
                table: "Person",
                column: "IdentityUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_AspNetUsers_IdentityUserId",
                table: "Person",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Person_AspNetUsers_IdentityUserId",
                table: "Person");

            migrationBuilder.DropIndex(
                name: "IX_Person_IdentityUserId",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "IdentityUserId",
                table: "Person");
        }
    }
}
