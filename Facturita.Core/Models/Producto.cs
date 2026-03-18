using System.Collections.Generic;

namespace Facturita.Core.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Codigo { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Stock { get; set; }

        public ICollection<VentaDetalle> VentaDetalles { get; set; } = new List<VentaDetalle>();
        public ICollection<CompraDetalle> CompraDetalles { get; set; } = new List<CompraDetalle>();
    }
}
