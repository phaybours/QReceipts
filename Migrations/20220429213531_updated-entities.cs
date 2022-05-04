using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QReceipts.Migrations
{
    public partial class updatedentities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BillToCountry",
                table: "Receipts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BillToState",
                table: "Receipts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BillToZipCode",
                table: "Receipts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Receipts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "InvoiceNo",
                table: "Receipts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Receipts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShipToCountry",
                table: "Receipts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShipToState",
                table: "Receipts",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BillToCountry",
                table: "Receipts");

            migrationBuilder.DropColumn(
                name: "BillToState",
                table: "Receipts");

            migrationBuilder.DropColumn(
                name: "BillToZipCode",
                table: "Receipts");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Receipts");

            migrationBuilder.DropColumn(
                name: "InvoiceNo",
                table: "Receipts");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Receipts");

            migrationBuilder.DropColumn(
                name: "ShipToCountry",
                table: "Receipts");

            migrationBuilder.DropColumn(
                name: "ShipToState",
                table: "Receipts");
        }
    }
}
