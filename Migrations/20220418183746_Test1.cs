using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EAD_CA_PROJECT_INVEST.Migrations
{
    public partial class Test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stock_Order_OrderID",
                table: "Stock");

            migrationBuilder.DropIndex(
                name: "IX_Stock_OrderID",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "OrderID",
                table: "Stock");

            migrationBuilder.AddColumn<int>(
                name: "StockID",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Order_StockID",
                table: "Order",
                column: "StockID");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Stock_StockID",
                table: "Order",
                column: "StockID",
                principalTable: "Stock",
                principalColumn: "StockID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Stock_StockID",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_StockID",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "StockID",
                table: "Order");

            migrationBuilder.AddColumn<int>(
                name: "OrderID",
                table: "Stock",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Stock_OrderID",
                table: "Stock",
                column: "OrderID");

            migrationBuilder.AddForeignKey(
                name: "FK_Stock_Order_OrderID",
                table: "Stock",
                column: "OrderID",
                principalTable: "Order",
                principalColumn: "OrderID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
