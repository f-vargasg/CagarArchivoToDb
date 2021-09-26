using CagarArchivoToDb.BE;
using CagarArchivoToDb.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CagarArchivoToDb.BL
{
    public class AsignaMercBL
    {
        AsignaMercDL asignaMercDL;

        public AsignaMercBL()
        {
            this.asignaMercDL = new AsignaMercDL();
        }
        public void Insertar(AsignaMercBE pParams)
        {
            try
            {
                this.asignaMercDL.Insertar(pParams);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
