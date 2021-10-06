using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNVal.Sab.BE.CyLiq
{
    public class DetalleProcesoBE
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }

        public override string ToString()
        {
            return "DetalleProceso: { Codigo => " + this.Codigo.ToString() + " - Descripcion => " + this.Descripcion + "}";
        }
    }
}
