using Microsoft.EntityFrameworkCore.Migrations;

namespace QReceipts.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Receipts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BillToName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BillToAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BillToCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BillToPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BillToEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShipToName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShipToAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShipToCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShipToPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShipToContact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Client = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receipts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReceiptItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReceiptId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LineTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceiptItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReceiptItems_Receipts_ReceiptId",
                        column: x => x.ReceiptId,
                        principalTable: "Receipts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptItems_ReceiptId",
                table: "ReceiptItems",
                column: "ReceiptId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReceiptItems");

            migrationBuilder.DropTable(
                name: "Receipts");
        }
    }
}
