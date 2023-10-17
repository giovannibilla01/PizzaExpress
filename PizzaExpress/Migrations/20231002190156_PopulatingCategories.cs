using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzaExpress.Migrations
{
    /// <inheritdoc />
    public partial class PopulatingCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Category(Name, Description) VALUES('Pizzas','Feitos com ingredientes frescos')");
            migrationBuilder.Sql("INSERT INTO Category(Name, Description) VALUES('Sobremesas','Sobremesas Deliciosas')");
            migrationBuilder.Sql("INSERT INTO Category(Name, Description) VALUES('Bebidas','Bebidas Variadas')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Category");
        }
    }
}
