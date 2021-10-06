using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNVal.Sab.BE.CyLiq
{
    public class DetalleAsignacionBE
    {
        public int IdOperacion { get; set; }
        public int IdAsignacion { get; set; }
        public string NumeroMercado { get; set; }
        public string NombreParticipante { get; set; }
        public string ContraParte { get; set; }
        public string CompraVenta { get; set; }
        public string TipoAsignacion { get; set; }
        public int NroAsignacion { get; set; }
        public string Estado { get; set; }
        public DateTime FechaConcertacion { get; set; }
        public DateTime FechaAsignacion { get; set; }
        public DateTime FechaLiquidacion { get; set; }
        public int IdEstadoMatching { get; set; }
        public string EstadoMatching { get; set; }
        public string Isin { get; set; }
        public string CodigoMAE { get; set; }
        public string Clasificacion { get; set; }
        public string CodigoCv { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }
        public string CuentaVn { get; set; }
        public string CustodioVn { get; set; }
        public string EntiliquidadorActual { get; set; }
        public string CuentaEfectivo { get; set; }
        public string CustodioEfectivo { get; set; }
        public string TipoLiquidacionActual { get; set; }
        public string TipoLiquidacionOriginal { get; set; }
        public decimal MontoEfectivo { get; set; }
        public decimal Comision { get; set; }
        public string MonedaCodigoSwift { get; set; }
        public string Operatoria { get; set; }
        public string Parte { get; set; }
        public bool Derivada { get; set; }
        public string NotasCustodio { get; set; }
        public string NotasAgente { get; set; }
        public int IdEstado { get; set; }
        public string CentralValoresEfectivo { get; set; }
        public string CentralValoresProducto { get; set; }
        public string CodigoLiquidacion { get; set; }
        public string Cuit { get; set; }
        public string TipoObservacionAsignacion { get; set; }
        public int IdNegociacion { get; set; }
        public string NumeroPata { get; set; }
        public string CodigoEstado { get; set; }
        public string CuentaVnDepositante { get; set; }
    }
}
