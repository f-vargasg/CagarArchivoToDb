using CagarArchivoToDb.BE;
using CagarArchivoToDb.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CagarArchivoToDb.BL
{
    public class AsignaMercDetBL
    {
        AsignaMercDetDL asignaMercDetDL;

        public AsignaMercDetBL()
        {
            this.asignaMercDetDL = new AsignaMercDetDL();
        }

        public void Insertar(AsignaMercDetBE pParams)
        {
            try
            {
                this.asignaMercDetDL.Insertar(pParams);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
