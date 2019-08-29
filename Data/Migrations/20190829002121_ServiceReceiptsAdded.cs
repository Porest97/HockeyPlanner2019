using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HockeyPlanner2019.Data.Migrations
{
    public partial class ServiceReceiptsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ServiceName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceReceipt",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PersonId = table.Column<int>(nullable: true),
                    ServiceId = table.Column<int>(nullable: true),
                    Quantity = table.Column<double>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    TotalPayment = table.Column<double>(nullable: false),
                    CompanyId = table.Column<int>(nullable: true),
                    TotalAmountPaid = table.Column<double>(nullable: false),
                    TotalAmountToPay = table.Column<double>(nullable: false),
                    ReceiptStatusId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceReceipt", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceReceipt_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ServiceReceipt_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ServiceReceipt_ReceiptStatus_ReceiptStatusId",
                        column: x => x.ReceiptStatusId,
                        principalTable: "ReceiptStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ServiceReceipt_Service_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Service",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ServiceReceipt_CompanyId",
                table: "ServiceReceipt",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceReceipt_PersonId",
                table: "ServiceReceipt",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceReceipt_ReceiptStatusId",
                table: "ServiceReceipt",
                column: "ReceiptStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceReceipt_ServiceId",
                table: "ServiceReceipt",
                column: "ServiceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ServiceReceipt");

            migrationBuilder.DropTable(
                name: "Service");
        }
    }
}
