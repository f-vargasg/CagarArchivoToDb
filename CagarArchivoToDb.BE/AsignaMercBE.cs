using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CagarArchivoToDb.BE
{
    public class AsignaMercBE
    {
        public string DesRespconfrech { get; set; }
        public int ?NumAsignaN { get; set; }
        public int Operationcode { get; set; }
        public string Statecode { get; set; }
        public string Parttype { get; set; }
        public string Centralsecurityrepository { get; set; }
        public string Currencycode { get; set; }
        public string Allocationcode { get; set; }
        public string Allocationentity { get; set; }
        public string Payerbank { get; set; }
        public decimal Facialvalue { get; set; }
        public decimal Tradedvalue { get; set; }
        public decimal Commissionamount { get; set; }
        public decimal Commissionamountmo { get; set; }
        public decimal Tax { get; set; }
        public decimal Acruedinterest { get; set; }
        public decimal Totaltradedvalue { get; set; }
        public string Isin { get; set; }
        public string Account { get; set; }
        public string Reserveaccount { get; set; }
        public string Cashaccount { get; set; }
        public decimal Ponderedpriceyield { get; set; }
        public DateTime Settlementdate { get; set; }
        public int Agreementyield { get; set; }
        public decimal Guarantypercent { get; set; }
        public int Actiontype { get; set; }
        public int CodEstadoN { get; set; }
        public decimal CodRegistroN { get; set; }
    }
}
