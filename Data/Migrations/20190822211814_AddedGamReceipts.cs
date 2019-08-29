using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HockeyPlanner2019.Data.Migrations
{
    public partial class AddedGamReceipts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReceiptStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReceiptStatusName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceiptStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GameReceipt",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GameId = table.Column<int>(nullable: true),
                    PersonId = table.Column<int>(nullable: true),
                    PersonId1 = table.Column<int>(nullable: true),
                    PersonId2 = table.Column<int>(nullable: true),
                    PersonId3 = table.Column<int>(nullable: true),
                    HD1Fee = table.Column<int>(nullable: false),
                    HD1TravelKost = table.Column<int>(nullable: false),
                    HD1Alowens = table.Column<int>(nullable: false),
                    HD1LateGameKost = table.Column<int>(nullable: false),
                    HD1TotalFee = table.Column<int>(nullable: false),
                    HD2Fee = table.Column<int>(nullable: false),
                    HD2TravelKost = table.Column<int>(nullable: false),
                    HD2Alowens = table.Column<int>(nullable: false),
                    HD2LateGameKost = table.Column<int>(nullable: false),
                    HD2TotalFee = table.Column<int>(nullable: false),
                    LD1Fee = table.Column<int>(nullable: false),
                    LD1TravelKost = table.Column<int>(nullable: false),
                    LD1Alowens = table.Column<int>(nullable: false),
                    LD1LateGameKost = table.Column<int>(nullable: false),
                    LD1TotalFee = table.Column<int>(nullable: false),
                    LD2Fee = table.Column<int>(nullable: false),
                    LD2TravelKost = table.Column<int>(nullable: false),
                    LD2Alowens = table.Column<int>(nullable: false),
                    LD2LateGameKost = table.Column<int>(nullable: false),
                    LD2TotalFee = table.Column<int>(nullable: false),
                    GameTotalKost = table.Column<int>(nullable: false),
                    AmountPaidHD1 = table.Column<int>(nullable: false),
                    AmountPaidHD2 = table.Column<int>(nullable: false),
                    AmountPaidLD1 = table.Column<int>(nullable: false),
                    AmountPaidLD2 = table.Column<int>(nullable: false),
                    TotalAmountPaid = table.Column<int>(nullable: false),
                    TotalAmountToPay = table.Column<int>(nullable: false),
                    ReceiptStatusId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameReceipt", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GameReceipt_Game_GameId",
                        column: x => x.GameId,
                        principalTable: "Game",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GameReceipt_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GameReceipt_Person_PersonId1",
                        column: x => x.PersonId1,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GameReceipt_Person_PersonId2",
                        column: x => x.PersonId2,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GameReceipt_Person_PersonId3",
                        column: x => x.PersonId3,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GameReceipt_ReceiptStatus_ReceiptStatusId",
                        column: x => x.ReceiptStatusId,
                        principalTable: "ReceiptStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GameReceipt_GameId",
                table: "GameReceipt",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_GameReceipt_PersonId",
                table: "GameReceipt",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_GameReceipt_PersonId1",
                table: "GameReceipt",
                column: "PersonId1");

            migrationBuilder.CreateIndex(
                name: "IX_GameReceipt_PersonId2",
                table: "GameReceipt",
                column: "PersonId2");

            migrationBuilder.CreateIndex(
                name: "IX_GameReceipt_PersonId3",
                table: "GameReceipt",
                column: "PersonId3");

            migrationBuilder.CreateIndex(
                name: "IX_GameReceipt_ReceiptStatusId",
                table: "GameReceipt",
                column: "ReceiptStatusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GameReceipt");

            migrationBuilder.DropTable(
                name: "ReceiptStatus");
        }
    }
}
