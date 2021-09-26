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
    public class AllocationFileVoDL : DataWorker
    {

        public void Insertar(AllocationFileVoBE pParams)
        {
            try
            {
                using (DbConnection connection = database.CreateOpenConnection())
                {
                    using (DbCommand command = database.CreateStoredProcCommand("VO_PAMBSCALLOCATIONSFILEVO.Inserta", connection))
                    {

                        DbParameter param = database.CreateParameter("pFilename", DbType.String, pParams.Filename);
                        command.Parameters.Add(param);
                        param = database.CreateParameter("pFEC_REGISTRO", DbType.DateTime, pParams.FecRegistro);
                        command.Parameters.Add(param);
                        param = database.CreateParameter("pCRC1", DbType.Decimal, pParams.Crc1);
                        command.Parameters.Add(param);
                        param = database.CreateParameter("pCRC2", DbType.Decimal, pParams.Crc2);
                        command.Parameters.Add(param);
                        param = database.CreateParameter("pCRC3", DbType.Decimal, pParams.Crc3);
                        command.Parameters.Add(param);
                        param = database.CreateParameter("pENTITY", DbType.Decimal, pParams.Entity);
                        command.Parameters.Add(param);
                        param = database.CreateParameter("pIND_CARGA", DbType.String, pParams.IndCarga);
                        command.Parameters.Add(param);
                        param = database.CreateParameter("pUSU_INGRESO", DbType.String, pParams.UsuIngreso);
                        command.Parameters.Add(param);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        public void Borrar(String pFilename)
        {
            try
            {
                using (DbConnection connection = database.CreateOpenConnection())
                {
                    using (DbCommand command = database.CreateStoredProcCommand("VO_PAMBSCALLOCATIONSFILEVO.Borra", connection))
                    {
                        DbParameter param = database.CreateParameter("pFilename", DbType.String, pFilename);
                        command.Parameters.Add(param);
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
