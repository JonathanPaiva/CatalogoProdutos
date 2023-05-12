using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatalogoProdutosAPI.Migrations
{
    public partial class PopulaProdutos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Produtos(Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " + 
                "VALUES('Coca Cola', 'Coca Cola 2L', 5.50, 'cocacola.jpg', 1, now(), 1)" );

            migrationBuilder.Sql("INSERT INTO Produtos(Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " +
                "VALUES('Sanduíche', 'Sanduíche', 3.5, 'sanduíche.jpg', 2, now(), 2)");

            migrationBuilder.Sql("INSERT INTO Produtos(Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " +
                "VALUES('Bolo Chocolate', 'Bolo Chocolate', 10.5, 'bolochocolate.jpg', 1, now(), 3)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Produtos");
        }
    }
}
