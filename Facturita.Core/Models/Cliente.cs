using System.Collections.Generic;

namespace Facturita.Core.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string Identificacion { get; set; } = string.Empty; // Cedula / RNC
        public string Direccion { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        
        public ICollection<Venta> Ventas { get; set; } = new List<Venta>();
    }
}
