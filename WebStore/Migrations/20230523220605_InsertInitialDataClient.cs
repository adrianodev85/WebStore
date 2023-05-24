using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebStore.Migrations
{
    /// <inheritdoc />
    public partial class InsertInitialDataClient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Cliente(Name,Cidade)" + "VALUES('Adriano Pinho','Curitiba')");
            migrationBuilder.Sql("INSERT INTO Cliente(Name,Cidade)" + "VALUES('Erica Victoria','Curitiba')");
            migrationBuilder.Sql("INSERT INTO Cliente(Name,Cidade)" + "VALUES('Bruno Vijal','Sao Paulo')");
            migrationBuilder.Sql("INSERT INTO Cliente(Name,Cidade)" + "VALUES('Jeferson Medeiros','Belo Horizonte')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Cliente");
        }
    }
}
