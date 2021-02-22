using Microsoft.EntityFrameworkCore.Migrations;

namespace KH095.Migrations
{
    public partial class update_table_product_types : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductTypeParentId",
                table: "ProductTypes",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TypeParentId",
                table: "ProductTypes",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ProductTypes_ProductTypeParentId",
                table: "ProductTypes",
                column: "ProductTypeParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTypes_ProductTypes_ProductTypeParentId",
                table: "ProductTypes",
                column: "ProductTypeParentId",
                principalTable: "ProductTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductTypes_ProductTypes_ProductTypeParentId",
                table: "ProductTypes");

            migrationBuilder.DropIndex(
                name: "IX_ProductTypes_ProductTypeParentId",
                table: "ProductTypes");

            migrationBuilder.DropColumn(
                name: "ProductTypeParentId",
                table: "ProductTypes");

            migrationBuilder.DropColumn(
                name: "TypeParentId",
                table: "ProductTypes");
        }
    }
}
