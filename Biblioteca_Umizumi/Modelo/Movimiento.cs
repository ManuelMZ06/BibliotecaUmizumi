using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Umizumi.Modelo
{
    namespace BibliotecaUmizumi.Modelo
    {
        public class Movimiento
        {
            public int IdMovimiento { get; set; }
            public int IdLibro { get; set; }
            public string TituloLibro { get; set; } // opcional, útil para mostrar
            public string TipoMovimiento { get; set; }
            public int Cantidad { get; set; }
            public DateTime FechaMovimiento { get; set; }
            public int IdUsuario { get; set; }
            public string NombreUsuario { get; set; } // opcional
            public string Observaciones { get; set; }
            public bool Status { get; set; }
        }
    }

}
