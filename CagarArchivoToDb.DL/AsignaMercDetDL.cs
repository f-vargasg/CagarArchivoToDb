using CagarArchivoToDb.BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CagarArchivoToDb.DL
{
    public class AsignaMercDetDL : DataWorker
    {
        public void Insertar(AsignaMercDetBE pParams)
        {
            try
            {
                using (DbConnection connection = database.CreateOpenConnection())
                {
                    using (DbCommand command = database.CreateStoredProcCommand("VO_PAMBSCALLOCATIONSFILEVO.Inserta", connection))
                    {
                        DbParameter param = database.CreateParameter("PNUM_ASIGNA_N", DbType.Decimal, pParams.NumAsignaN); command.Parameters.Add(param);
                        param = database.CreateParameter("PNUMDETAIL", DbType.Decimal, null); command.Parameters.Add(param);
                        param = database.CreateParameter("PPARTNUMBER", DbType.Decimal, pParams.Partnumber); command.Parameters.Add(param);
                        param = database.CreateParameter("PCONTRACTCODE", DbType.String, pParams.Contractcode); command.Parameters.Add(param);
                        param = database.CreateParameter("PTOTALTRADEDVALUE", DbType.Decimal, pParams.Totaltradedvalue); command.Parameters.Add(param);
                        param = database.CreateParameter("PTOTALFACIALVALUE", DbType.Decimal, pParams.Totalfacialvalue); command.Parameters.Add(param);
                        param = database.CreateParameter("PCOD_ESTADO_N", DbType.Decimal, pParams.CodEstadoN); command.Parameters.Add(param);
                        param = database.CreateParameter("PCOD_USUARIOREG_V", DbType.String, "AUTO"); command.Parameters.Add(param);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
