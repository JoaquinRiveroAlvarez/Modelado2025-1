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
    public class DetallePedidoRepositorio : Repositorio<DetallePedido>, IDetallePedidoRepositorio
    {
        private readonly AppDbContext context;

        public DetallePedidoRepositorio(AppDbContext context) : base(context)
        {
            this.context = context;
        }
    }
}
