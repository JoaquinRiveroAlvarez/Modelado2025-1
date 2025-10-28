using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelado2025_1BD.Migrations
{
    /// <inheritdoc />
    public partial class Inicio2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Pedidos_PedidoId",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Productos_PedidoId",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "PedidoId",
                table: "Productos");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PedidoId",
                table: "Productos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Productos_PedidoId",
                table: "Productos",
                column: "PedidoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Pedidos_PedidoId",
                table: "Productos",
                column: "PedidoId",
                principalTable: "Pedidos",
                principalColumn: "Id");
        }
    }
}
