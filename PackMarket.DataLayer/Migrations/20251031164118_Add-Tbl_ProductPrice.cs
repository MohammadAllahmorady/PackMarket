using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PackMarket.DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class AddTbl_ProductPrice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductPrices",
                columns: table => new
                {
                    ProductPriceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MainPrice = table.Column<int>(type: "int", nullable: false),
                    SpecialPrice = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    MaxOrderCount = table.Column<int>(type: "int", nullable: false),
                    ProductColorId = table.Column<int>(type: "int", nullable: false),
                    ProductGuranteeId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDateDisCount = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPrices", x => x.ProductPriceId);
                    table.ForeignKey(
                        name: "FK_ProductPrices_ProductColors_ProductColorId",
                        column: x => x.ProductColorId,
                        principalTable: "ProductColors",
                        principalColumn: "ColorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductPrices_ProductGurantees_ProductGuranteeId",
                        column: x => x.ProductGuranteeId,
                        principalTable: "ProductGurantees",
                        principalColumn: "GuranteeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductPrices_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductPrices_ProductColorId",
                table: "ProductPrices",
                column: "ProductColorId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPrices_ProductGuranteeId",
                table: "ProductPrices",
                column: "ProductGuranteeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPrices_ProductId",
                table: "ProductPrices",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductPrices");
        }
    }
}
