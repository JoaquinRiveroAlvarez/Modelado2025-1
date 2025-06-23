using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelado2025_1BD.Migrations
{
    /// <inheritdoc />
    public partial class inicio4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Pedidos_DetallePedidoId",
                table: "Pedidos");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_DetallePedidoId",
                table: "Pedidos",
                column: "DetallePedidoId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Pedidos_DetallePedidoId",
                table: "Pedidos");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_DetallePedidoId",
                table: "Pedidos",
                column: "DetallePedidoId");
        }
    }
}
