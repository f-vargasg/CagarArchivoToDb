using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CagarArchivoToDb.BE
{
    public class AllocationFileVoBE
    {
        public string Filename { get; set; }
        public DateTime FecRegistro { get; set; }
        public decimal Crc1 { get; set; }
        public decimal Crc2 { get; set; }
        public decimal Crc3 { get; set; }
        public int Entity { get; set; }
        public string IndCarga { get; set; }
        public string UsuIngreso { get; set; }
        public DateTime FecIngreso { get; set; }
    }
}
