using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelado2025_1BD.Migrations
{
    /// <inheritdoc />
    public partial class inicio7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_DetallePedidos_DetallePedidoId",
                table: "Pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductoPedido_Pedidos_PedidoId",
                table: "ProductoPedido");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductoPedido_Productos_ProductoId",
                table: "ProductoPedido");

            migrationBuilder.DropForeignKey(
                name: "FK_Productos_TipoProductos_TipoProductoId",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_DetallePedidoId",
                table: "Pedidos");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_DetallePedidoId",
                table: "Pedidos",
                column: "DetallePedidoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_DetallePedidos_DetallePedidoId",
                table: "Pedidos",
                column: "DetallePedidoId",
                principalTable: "DetallePedidos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductoPedido_Pedidos_PedidoId",
                table: "ProductoPedido",
                column: "PedidoId",
                principalTable: "Pedidos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductoPedido_Productos_ProductoId",
                table: "ProductoPedido",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_TipoProductos_TipoProductoId",
                table: "Productos",
                column: "TipoProductoId",
                principalTable: "TipoProductos",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_DetallePedidos_DetallePedidoId",
                table: "Pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductoPedido_Pedidos_PedidoId",
                table: "ProductoPedido");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductoPedido_Productos_ProductoId",
                table: "ProductoPedido");

            migrationBuilder.DropForeignKey(
                name: "FK_Productos_TipoProductos_TipoProductoId",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_DetallePedidoId",
                table: "Pedidos");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_DetallePedidoId",
                table: "Pedidos",
                column: "DetallePedidoId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_DetallePedidos_DetallePedidoId",
                table: "Pedidos",
                column: "DetallePedidoId",
                principalTable: "DetallePedidos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductoPedido_Pedidos_PedidoId",
                table: "ProductoPedido",
                column: "PedidoId",
                principalTable: "Pedidos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductoPedido_Productos_ProductoId",
                table: "ProductoPedido",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_TipoProductos_TipoProductoId",
                table: "Productos",
                column: "TipoProductoId",
                principalTable: "TipoProductos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
