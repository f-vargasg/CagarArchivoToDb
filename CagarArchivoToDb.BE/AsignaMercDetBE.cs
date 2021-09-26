using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CagarArchivoToDb.BE
{
    public class AsignaMercDetBE
    {
        public int ?NumAsignaN { get; set; }
        public int ?Numdetail { get; set; }
        public int Partnumber { get; set; }
        public string Contractcode { get; set; }
        public decimal Totaltradedvalue { get; set; }
        public decimal Totalfacialvalue { get; set; }
        public decimal MtoRemanente { get; set; }
        public int CodEstadoN { get; set; }
        public int CodRegistroN { get; set; }
        public int IndInstrgenN { get; set; }
    }
}
