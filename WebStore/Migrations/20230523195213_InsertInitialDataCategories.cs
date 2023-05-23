using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebStore.Migrations
{
    /// <inheritdoc />
    public partial class InsertInitialDataCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(CategNome)" + "VALUES('Computing')");
            migrationBuilder.Sql("INSERT INTO Categorias(CategNome)" + "VALUES('Games')");
            migrationBuilder.Sql("INSERT INTO Categorias(CategNome)" + "VALUES('Telephony')");
            migrationBuilder.Sql("INSERT INTO Categorias(CategNome)" + "VALUES('Software')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}
