using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzaExpress.Migrations
{
    /// <inheritdoc />
    public partial class PopulatingProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Product(Name, Description, LongDescription, Price, ImageUrl, ThumbnailUrl, Favorite, Stock, CategoryId) VALUES('Calabresa', 'Massa Tradicional, Queijo Mussarela, Calabrasa, Tomate e Oregano', 'Deliciosa Pizza de Calabresa com os ingredientes mais frescos possivel, delicia, expetacular', 35.99, 'https://blog.novasafra.com.br/wp-content/uploads/2016/01/accb7d_37d37d9f1001e88384dafc6e5cc60c4f.jpg_1024-780x450.jpg', null, 0, 1, 1)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Product");
        }
    }
}