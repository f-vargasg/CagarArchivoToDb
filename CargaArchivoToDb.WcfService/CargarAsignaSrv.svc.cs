using CagarArchivoToDb.BE;
using CagarArchivoToDb.BL;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using TestingBE;

namespace CargaArchivoToDb.WcfService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class CargarAsignaSrv : ICargarAsignaSrv
    {
        public void CargarAsignacion(string pData)
        {
            try
            {
                AsignaMercDetBL asignaMercDetBL = new AsignaMercDetBL();
                AsignaMercBL asignaMercBL = new AsignaMercBL();
                var respProc = JsonConvert.DeserializeObject<GeneralResponseCylBE<RespaAsignaBE>>(pData);
                if (respProc != null)
                {
                    if (respProc.Data != null)
                    {
                        if (respProc.Data.Data != null)
                        {
                            if (respProc.Data.Data.Success)
                            {
                                foreach (var item in respProc.Data.Data.Data)
                                {
                                    AsignaMercBE asignaMercBE = new AsignaMercBE
                                    {
                                        Account = item.CuentaVn,
                                        Acruedinterest = Convert.ToDecimal(0.00),
                                        Actiontype = 1,
                                        Agreementyield = 0,
                                        Allocationcode = item.NroAsignacion.ToString(),
                                        Allocationentity = item.ContraParte,
                                        NumAsignaN = null,
                                        Cashaccount = item.CuentaEfectivo,
                                        Centralsecurityrepository = "08",
                                        CodEstadoN = 2,
                                        CodRegistroN = Convert.ToDecimal(0),
                                        Commissionamount = item.Comision,
                                        Commissionamountmo = Convert.ToDecimal(0),
                                        Currencycode = item.MonedaCodigoSwift,
                                        DesRespconfrech = string.Empty,
                                        Facialvalue = item.Cantidad,
                                        Guarantypercent = Convert.ToDecimal(0),
                                        Isin = item.Isin,
                                        Operationcode = 10,
                                        Parttype = item.Parte,
                                        Payerbank = item.EntiliquidadorActual,
                                        Ponderedpriceyield = Convert.ToDecimal(0.00),
                                        Reserveaccount = item.CuentaVnDepositante,
                                        Settlementdate = item.FechaLiquidacion,
                                        Statecode = item.Estado,
                                        Tax = Convert.ToDecimal(0.00),
                                        Totaltradedvalue = item.MontoEfectivo,
                                        Tradedvalue = item.MontoEfectivo
                                    };
                                    AsignaMercDetBE asignaMercDetBE = new AsignaMercDetBE()
                                    {
                                        NumAsignaN = null,
                                        CodEstadoN = 2,
                                        CodRegistroN = 24242,
                                        Contractcode = item.NumeroMercado,
                                        IndInstrgenN = 0,
                                        MtoRemanente = item.Cantidad,
                                        Numdetail = null,
                                        Partnumber = (item.Parte == "Contado" ? 1 : 2),
                                        Totalfacialvalue = item.Cantidad,
                                        Totaltradedvalue = item.MontoEfectivo
                                    };
                                    asignaMercBL.Insertar(asignaMercBE);
                                    asignaMercDetBL.Insertar(asignaMercDetBE);
                                }
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
