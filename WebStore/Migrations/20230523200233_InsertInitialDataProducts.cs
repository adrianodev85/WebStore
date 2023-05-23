using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebStore.Migrations
{
    /// <inheritdoc />
    public partial class InsertInitialDataProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Produtos(Descricao,DescricaoDetalhada,ValorUnitario,CategoriaId,ImgUrl,ImgThumbnailUrl,Preferido,EmEstoque)"
                + "VALUES('X-Box Serie X','X-Box Serie X, 1TB SSD, 2 Wireless Controls, 16GB GDDR6 RAM, 8k HDR',4499.00,2,'~/wwwroot/img/xboxseriex.jpg','~/wwwroot/img/thumbxboxseriex.jpg',1,1)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Produtos");
        }
    }
}
