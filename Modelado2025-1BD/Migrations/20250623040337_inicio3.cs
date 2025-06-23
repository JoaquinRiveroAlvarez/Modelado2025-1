using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelado2025_1BD.Migrations
{
    /// <inheritdoc />
    public partial class inicio3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductoPedidos_Pedidos_PedidoId",
                table: "ProductoPedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductoPedidos_Productos_ProductoId",
                table: "ProductoPedidos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductoPedidos",
                table: "ProductoPedidos");

            migrationBuilder.RenameTable(
                name: "ProductoPedidos",
                newName: "ProductoPedido");

            migrationBuilder.RenameIndex(
                name: "IX_ProductoPedidos_PedidoId",
                table: "ProductoPedido",
                newName: "IX_ProductoPedido_PedidoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductoPedido",
                table: "ProductoPedido",
                columns: new[] { "ProductoId", "PedidoId" });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductoPedido_Pedidos_PedidoId",
                table: "ProductoPedido");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductoPedido_Productos_ProductoId",
                table: "ProductoPedido");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductoPedido",
                table: "ProductoPedido");

            migrationBuilder.RenameTable(
                name: "ProductoPedido",
                newName: "ProductoPedidos");

            migrationBuilder.RenameIndex(
                name: "IX_ProductoPedido_PedidoId",
                table: "ProductoPedidos",
                newName: "IX_ProductoPedidos_PedidoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductoPedidos",
                table: "ProductoPedidos",
                columns: new[] { "ProductoId", "PedidoId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ProductoPedidos_Pedidos_PedidoId",
                table: "ProductoPedidos",
                column: "PedidoId",
                principalTable: "Pedidos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductoPedidos_Productos_ProductoId",
                table: "ProductoPedidos",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "Id");
        }
    }
}
