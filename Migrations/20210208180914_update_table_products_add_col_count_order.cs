using Microsoft.EntityFrameworkCore.Migrations;

namespace KH095.Migrations
{
    public partial class update_table_products_add_col_count_order : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CountOrder",
                table: "Products",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CountOrder",
                table: "Products");
        }
    }
}
