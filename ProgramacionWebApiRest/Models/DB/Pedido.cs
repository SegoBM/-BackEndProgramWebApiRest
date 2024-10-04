using System;
using System.Collections.Generic;

namespace ProgramacionWebApiRest.Models.DB;

public partial class Pedido
{
    public Guid PedidoId { get; set; }

    public Guid? ClienteId { get; set; }

    public DateTime Fecha { get; set; }

    public decimal Total { get; set; }

    public virtual Cliente? Cliente { get; set; }

    public virtual ICollection<DetallesPedido> DetallesPedidos { get; set; } = new List<DetallesPedido>();
}
