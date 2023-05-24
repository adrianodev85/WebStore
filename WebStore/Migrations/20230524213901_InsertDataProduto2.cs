using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebStore.Migrations
{
    /// <inheritdoc />
    public partial class InsertDataProduto2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Produtos(Descricao," +
                "DescricaoDetalhada," +
                "ValorUnitario," +
                "CategoriaId," +
                "ImgUrl," +
                "ImgThumbnailUrl," +
                "Preferido," +
                "EmEstoque)"
               + "VALUES('ASUS ZenBook Pro Duo Core I9','ASUS Zenbook Pro Duo, Core I9 10th Gen, 32GB RAM, 1TB SSD, NVIDIA GeForce RTX 2060, 15.6 inches 4k UHD',8999.00,1,'https://m.media-amazon.com/images/I/91ytMW7sXXL._AC_SY450_.jpg','https://m.media-amazon.com/images/I/61pBgfnwArS.__AC_SX300_SY300_QL70_ML2_.jpg',1,1)");
            migrationBuilder.Sql("INSERT INTO Produtos(Descricao,DescricaoDetalhada,ValorUnitario,CategoriaId,ImgUrl,ImgThumbnailUrl,Preferido,EmEstoque)"
                + "VALUES('Motorola Edge 40','Motorola Edge 40, Android 13, 8GB RAM, 6.55 inches FHD+/HDR10+, Camera Traseira:50MP/Camera Frontal:32MP, 5G',3499.00,3,'https://specifications-pro.com/wp-content/uploads/2023/03/Motorola-Edge-40-Pro-600x600.jpg','https://images-na.ssl-images-amazon.com/images/I/51yd5TAAgUL._AC_UL200_SR200,200_.jpg',1,1)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Produtos");
        }
    }
}
