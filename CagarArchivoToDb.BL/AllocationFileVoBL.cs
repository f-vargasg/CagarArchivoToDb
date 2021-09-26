using CagarArchivoToDb.BE;
using CagarArchivoToDb.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CagarArchivoToDb.BL
{
    public class AllocationFileVoBL
    {
        AllocationFileVoDL allocationFileVoDL;

        public AllocationFileVoBL()
        {
            this.allocationFileVoDL = new AllocationFileVoDL();
        }

        public void Insertar(AllocationFileVoBE allocationFileVoBE)
        {
            try
            {
                this.allocationFileVoDL.Insertar(allocationFileVoBE);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Borrar(string pFilename)
        {
            try
            {
                this.allocationFileVoDL.Borrar(pFilename);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
