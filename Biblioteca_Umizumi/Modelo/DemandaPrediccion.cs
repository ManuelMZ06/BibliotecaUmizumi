using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Umizumi.Modelo
{
    public class DemandaPrediccion
    {
        public int IdLibro { get; set; }
        public DateTime Fecha { get; set; }
        public double Prediccion { get; set; }
    }
}
