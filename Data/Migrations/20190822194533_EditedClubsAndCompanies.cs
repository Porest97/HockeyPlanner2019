using Microsoft.EntityFrameworkCore.Migrations;

namespace HockeyPlanner2019.Data.Migrations
{
    public partial class EditedClubsAndCompanies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Club_Person_PersonId",
                table: "Club");

            migrationBuilder.DropForeignKey(
                name: "FK_Company_Person_PersonId",
                table: "Company");

            migrationBuilder.DropIndex(
                name: "IX_Company_PersonId",
                table: "Company");

            migrationBuilder.DropIndex(
                name: "IX_Club_PersonId",
                table: "Club");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Club");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Company",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Club",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Company_PersonId",
                table: "Company",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Club_PersonId",
                table: "Club",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Club_Person_PersonId",
                table: "Club",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Company_Person_PersonId",
                table: "Company",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
