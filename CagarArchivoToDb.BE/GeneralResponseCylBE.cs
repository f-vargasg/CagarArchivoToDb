using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNVal.Sab.BE.CyLiq
{
    public class GeneralResponseCylBE<T>
    {
        public System.Net.HttpStatusCode StatusResponseCode { get; set; }
        public String CodError { get; set; }
        public String Mensaje { get; set; }
        public bool OcurrioExcepcion { get; set; }
        public T Data { get; set; }

        public GeneralResponseCylBE()
        {
            this.StatusResponseCode = System.Net.HttpStatusCode.OK;
            this.CodError = String.Empty;
            this.Mensaje = String.Empty;
            this.OcurrioExcepcion = false;
        }
    }
}
