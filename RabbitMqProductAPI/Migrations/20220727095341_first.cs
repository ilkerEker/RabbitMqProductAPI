using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RabbitMqProductAPI.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    ProductName = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    ProductDescription = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    ProductPrice = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Productstock = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
