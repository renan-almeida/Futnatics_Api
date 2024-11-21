using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Futnatics.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CLIENTES",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Cpf = table.Column<int>(type: "int", nullable: false),
                    Rg = table.Column<int>(type: "int", nullable: false),
                    Endereco = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Email = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLIENTES", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PARTIDAS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estadio = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    TimeCasa = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    TimeFora = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PARTIDAS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TIMES",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Sigla = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    FundadoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cidade = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Estado = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Pais = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Estadio = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    MaiorRival = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Mascote = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Logo = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TIMES", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "CLIENTES",
                columns: new[] { "Id", "Cpf", "Email", "Endereco", "Nome", "Rg" },
                values: new object[,]
                {
                    { 1, 546812798, "Renanalmeidadantas2007@gmail.com", "Rua Jonas Cardoso N: 16B ", "Renan", 1241454213 },
                    { 2, 124345325, "DanilloLacerdad470", "Rua Serra Do Apodi", "Danillo", 235252436 },
                    { 3, 21345235, "FelipeSilva@gmail.com", "Rua Elisa do Apodi", "Felipe", 123542253 }
                });

            migrationBuilder.InsertData(
                table: "PARTIDAS",
                columns: new[] { "Id", "Data", "Estadio", "TimeCasa", "TimeFora" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 4, 20, 0, 0, 0, DateTimeKind.Unspecified), "Neo Quimica Arena", "Corinthians", "Palmeiras" },
                    { 2, new DateTime(2024, 11, 9, 16, 30, 0, 0, DateTimeKind.Unspecified), "Barradão", "Vitoria", "Corinthians" }
                });

            migrationBuilder.InsertData(
                table: "TIMES",
                columns: new[] { "Id", "Cidade", "Estadio", "Estado", "FundadoEm", "Logo", "MaiorRival", "Mascote", "Nome", "Pais", "Sigla" },
                values: new object[,]
                {
                    { 1, "São Paulo", "Neo Quimica Arena", "SP", new DateTime(1910, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.google.com/url?sa=i&url=https%3A%2F%2Fworldvectorlogo.com%2Fpt%2Flogo%2Fcorinthians-1&psig=AOvVaw3JIoaqcowrWn3X94Ey9eGX&ust=1732226050083000&source=images&cd=vfe&opi=89978449&ved=0CBQQjRxqFwoTCODnvYTz64kDFQAAAAAdAAAAABAJ", "Palmeiras", "Mosqueteiro", "Corinthians", "Brasil", "Sccp" },
                    { 2, "São Paulo", "Morumbi", "SP", new DateTime(1930, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.google.com/url?sa=i&url=https%3A%2F%2Fpt.m.wikipedia.org%2Fwiki%2FFicheiro%3AS%25C3%25A3o_Paulo_Futebol_Clube.png&psig=AOvVaw1xeJ1hMP53za1kzJirVB35&ust=1732226361260000&source=images&cd=vfe&opi=89978449&ved=0CBQQjRxqFwoTCPDDj53064kDFQAAAAAdAAAAABAI", "Corinthians", "Santo Paulo", "São Paulo", "Brasil", "SPFC" },
                    { 3, "Belo Horizonte", "Mineirão", "BH", new DateTime(1921, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.google.com/url?sa=i&url=https%3A%2F%2Fpt.m.wikipedia.org%2Fwiki%2FFicheiro%3AS%25C3%25A3o_Paulo_Futebol_Clube.png&psig=AOvVaw1xeJ1hMP53za1kzJirVB35&ust=1732226361260000&source=images&cd=vfe&opi=89978449&ved=0CBQQjRxqFwoTCPDDj53064kDFQAAAAAdAAAAABAI", "Atlético Mg", "Raposa", "Cruzeiro", "Brasil", "Cru" },
                    { 4, "Bragança Paulista", "Nabi Abi Chedid", "SP", new DateTime(1928, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.google.com/url?sa=i&url=https%3A%2F%2Fworldvectorlogo.com%2Fpt%2Flogo%2Fcorinthians-1&psig=AOvVaw3JIoaqcowrWn3X94Ey9eGX&ust=1732226050083000&source=images&cd=vfe&opi=89978449&ved=0CBQQjRxqFwoTCODnvYTz64kDFQAAAAAdAAAAABAJ", "Corinthians", "Touro", "Bragantino", "Brasil", "Bra" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CLIENTES");

            migrationBuilder.DropTable(
                name: "PARTIDAS");

            migrationBuilder.DropTable(
                name: "TIMES");
        }
    }
}
