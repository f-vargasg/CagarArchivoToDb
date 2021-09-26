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
    public class AsignaMercDL : DataWorker
    {
        public void Insertar(AsignaMercBE pParams)
        {
            try
            {
                using (DbConnection connection = database.CreateOpenConnection())
                {
                    using (DbCommand command = database.CreateStoredProcCommand("VO_PAMBSCALLOCATIONSFILEVO.Inserta", connection))
                    {
                            DbParameter param = database.CreateParameter("PNUM_ASIGNA_N", DbType.Decimal, null); 
                            command.Parameters.Add(param);
                            param = database.CreateParameter("POPERATIONCODE", DbType.Decimal, pParams.Operationcode); 
                            command.Parameters.Add(param);
                            param = database.CreateParameter("PSTATECODE", DbType.String, pParams.Statecode); 
                            command.Parameters.Add(param);
                            param = database.CreateParameter("PPARTTYPE", DbType.String, pParams.Parttype); 
                            command.Parameters.Add(param);
                            param = database.CreateParameter("PCENTRALSECURITYREPOSITORY", DbType.String, 
                            pParams.Centralsecurityrepository); 
                            command.Parameters.Add(param);
                            param = database.CreateParameter("PCURRENCYCODE", DbType.String, pParams.Currencycode); 
                            command.Parameters.Add(param);
                            param = database.CreateParameter("PALLOCATIONCODE", DbType.String, pParams.Allocationcode); 
                            command.Parameters.Add(param);
                            param = database.CreateParameter("PALLOCATIONENTITY", DbType.String, pParams.Allocationentity); 
                            command.Parameters.Add(param);
                            param = database.CreateParameter("PPAYERBANK", DbType.String, pParams.Payerbank); 
                            command.Parameters.Add(param);
                            param = database.CreateParameter("PFACIALVALUE", DbType.Decimal, pParams.Facialvalue); 
                            command.Parameters.Add(param);
                            param = database.CreateParameter("PTRADEDVALUE", DbType.Decimal, pParams.Tradedvalue); 
                            command.Parameters.Add(param);
                            param = database.CreateParameter("PCOMMISSIONAMOUNT", DbType.Decimal, pParams.Commissionamount); 
                            command.Parameters.Add(param);
                            param = database.CreateParameter("PCOMMISSIONAMOUNTMO", DbType.Decimal, pParams.Commissionamountmo); 
                            command.Parameters.Add(param);
                            param = database.CreateParameter("PTAX", DbType.Decimal, pParams.Tax); 
                            command.Parameters.Add(param);
                            param = database.CreateParameter("PACRUEDINTEREST", DbType.Decimal, pParams.Acruedinterest); 
                            command.Parameters.Add(param);
                            param = database.CreateParameter("PTOTALTRADEDVALUE", DbType.Decimal, pParams.Totaltradedvalue); 
                            command.Parameters.Add(param);
                            param = database.CreateParameter("PISIN", DbType.String, pParams.Isin); 
                            command.Parameters.Add(param);
                            param = database.CreateParameter("PACCOUNT", DbType.String, pParams.Account); 
                            command.Parameters.Add(param);
                            param = database.CreateParameter("PRESERVEACCOUNT", DbType.String, pParams.Reserveaccount); 
                            command.Parameters.Add(param);
                            param = database.CreateParameter("PCASHACCOUNT", DbType.String, pParams.Cashaccount); 
                            command.Parameters.Add(param);
                            param = database.CreateParameter("PPONDEREDPRICEYIELD", DbType.Decimal, pParams.Ponderedpriceyield); 
                            command.Parameters.Add(param);
                            param = database.CreateParameter("PSETTLEMENTDATE", DbType.DateTime, pParams.Settlementdate); 
                            command.Parameters.Add(param);
                            param = database.CreateParameter("PAGREEMENTYIELD", DbType.Decimal, pParams.Agreementyield); 
                            command.Parameters.Add(param);
                            param = database.CreateParameter("PGUARANTYPERCENT", DbType.Decimal, pParams.Guarantypercent); 
                            command.Parameters.Add(param);
                            param = database.CreateParameter("PACTIONTYPE", DbType.Decimal, pParams.Actiontype); 
                            command.Parameters.Add(param);
                            param = database.CreateParameter("PCOD_ESTADO_N", DbType.Decimal, pParams.CodEstadoN); 
                            command.Parameters.Add(param);
                            param = database.CreateParameter("PCOD_USUARIOREG_V", DbType.String, "AUTO"); 
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
