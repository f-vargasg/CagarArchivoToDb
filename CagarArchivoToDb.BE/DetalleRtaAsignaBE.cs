using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BNVal.Sab.BE.CyLiq
{
    public class DetalleRtaAsignaBE
    {
        public List<DetalleAsignacionBE> Data { get; set; }
        public bool Success { get; set; }
        public DetalleProcesoBE Process { get; set; }
    }
}
