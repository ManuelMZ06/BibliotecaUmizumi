using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Umizumi.Modelo
{
    internal class CRUDLibros
    {
    }

    public class Libro
    {
        public int IdLibro { get; set; }
        public string Titulo { get; set; }
        public int IdCategoria { get; set; }
        public int IdAutor { get; set; }
        public int Cantidad_Stock { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public string Descripcion { get; set; }
        public int IdProveedor { get; set; }

        public bool Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

}
