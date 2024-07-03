using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Migrar.Migrations
{
    /// <inheritdoc />
    public partial class seventhmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "destinos",
                keyColumn: "id_destino",
                keyValue: 1,
                column: "local_destino",
                value: "Paris");

            migrationBuilder.UpdateData(
                table: "destinos",
                keyColumn: "id_destino",
                keyValue: 2,
                column: "local_destino",
                value: "Toquio");

            migrationBuilder.UpdateData(
                table: "destinos",
                keyColumn: "id_destino",
                keyValue: 3,
                column: "local_destino",
                value: "Rio de Janeiro");

            migrationBuilder.UpdateData(
                table: "destinos",
                keyColumn: "id_destino",
                keyValue: 4,
                column: "local_destino",
                value: "Nova York");

            migrationBuilder.UpdateData(
                table: "destinos",
                keyColumn: "id_destino",
                keyValue: 5,
                column: "local_destino",
                value: "Sydney");

            migrationBuilder.UpdateData(
                table: "destinos",
                keyColumn: "id_destino",
                keyValue: 6,
                column: "local_destino",
                value: "Cidade do Cabo");

            migrationBuilder.InsertData(
                table: "destinos",
                columns: new[] { "id_destino", "foto_destino", "local_destino", "valor_destino" },
                values: new object[,]
                {
                    { 7, "https://images.pexels.com/photos/1388030/pexels-photo-1388030.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", "Barcelona", 1800.00m },
                    { 8, "https://images.pexels.com/photos/1519088/pexels-photo-1519088.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", "Toronto", 2400.00m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "destinos",
                keyColumn: "id_destino",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "destinos",
                keyColumn: "id_destino",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "destinos",
                keyColumn: "id_destino",
                keyValue: 1,
                column: "local_destino",
                value: "Paris, França");

            migrationBuilder.UpdateData(
                table: "destinos",
                keyColumn: "id_destino",
                keyValue: 2,
                column: "local_destino",
                value: "Tóquio, Japão");

            migrationBuilder.UpdateData(
                table: "destinos",
                keyColumn: "id_destino",
                keyValue: 3,
                column: "local_destino",
                value: "Rio de Janeiro, Brasil");

            migrationBuilder.UpdateData(
                table: "destinos",
                keyColumn: "id_destino",
                keyValue: 4,
                column: "local_destino",
                value: "Nova York, EUA");

            migrationBuilder.UpdateData(
                table: "destinos",
                keyColumn: "id_destino",
                keyValue: 5,
                column: "local_destino",
                value: "Sydney, Austrália");

            migrationBuilder.UpdateData(
                table: "destinos",
                keyColumn: "id_destino",
                keyValue: 6,
                column: "local_destino",
                value: "Cidade do Cabo, África do Sul");
        }
    }
}
