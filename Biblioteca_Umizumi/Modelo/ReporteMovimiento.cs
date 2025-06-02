using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Umizumi.Modelo
{
    public class ReporteMovimiento
    {
        public int IdMovimiento { get; set; }
        public DateTime FechaMovimiento { get; set; }
        public int Anio { get; set; }
        public int Mes { get; set; }
        public int Trimestre { get; set; }
        public int IdLibro { get; set; }
        public string Titulo { get; set; }
        public decimal PrecioVenta { get; set; }
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string TipoMovimiento { get; set; }
        public int Cantidad { get; set; }
    }
}