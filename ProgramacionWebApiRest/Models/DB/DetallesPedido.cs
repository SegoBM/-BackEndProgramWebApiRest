using System;
using System.Collections.Generic;

namespace ProgramacionWebApiRest.Models.DB;

public partial class DetallesPedido
{
    public Guid DetalleId { get; set; }

    public Guid? PedidoId { get; set; }

    public Guid? ProductoId { get; set; }

    public int Cantidad { get; set; }

    public decimal Precio { get; set; }

    public virtual Pedido? Pedido { get; set; }

    public virtual Producto? Producto { get; set; }
}
