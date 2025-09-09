using Microsoft.EntityFrameworkCore;
using Modelado2025_1BD.Datos;
using Modelado2025_1BD.Datos.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelado2025_1Repositorio.Repositorios
{
    public class PedidoRepositorio : Repositorio<Pedido>, IPedidoRepositorio
    {
        private readonly AppDbContext context;

        public PedidoRepositorio(AppDbContext context) : base(context)
        {
            this.context = context;
        }
        public async Task<Pedido?> SelectByCod(string cod)
        {
            return await context.Set<Pedido>().FirstOrDefaultAsync(x => x.Codigo == cod);
        }
    }
}
