using System;
using System.Collections.Generic;

namespace Facturita.Core.Models
{
    public class Compra
    {
        public int Id { get; set; }
        public int ProveedorId { get; set; }
        public Proveedor Proveedor { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }

        public ICollection<CompraDetalle> CompraDetalles { get; set; } = new List<CompraDetalle>();
    }
}
