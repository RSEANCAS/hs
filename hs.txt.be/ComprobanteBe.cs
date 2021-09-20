using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hs.txt.be
{
    public class ComprobanteBe
    {
        public string Version { get; set; }
        public string ComprobanteId { get; set; }
        public string CodigoTipoDocumento { get; set; }
        public string TipoOperacion { get; set; }
        public string RucEmisor { get; set; }
        public string CodigoSucursalSunat { get; set; }
        public DateTime FechaHoraEmision { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string TipoMoneda { get; set; }
        public decimal SubTotal { get; set; }
        public decimal TotalDescuentos { get; set; }
        public decimal TotalBaseImponible { get; set; }
        public decimal TotalIsc { get; set; }
        public decimal TotalIgv { get; set; }
        public decimal TotalOtrosCargos { get; set; }
        public decimal TotalOtrosTributos { get; set; }
        public decimal ImporteTotal { get; set; }
        public int TieneDocumentoReferencia { get; set; }
        public string TipoDocumentoReferencia { get; set; }
        public string SerieDocumentoReferencia { get; set; }
        public int NumeroDocumentoReferencia { get; set; }
        public string SerieDocumentoEmitir { get; set; }
        public int NumeroDocumentoEmitir { get; set; }
        public string UsuarioId { get; set; }
        public string Observacion { get; set; }
        public string CondicionPago { get; set; }
        public string NumeroOrdenCompra { get; set; }
        public string GuiaRemision { get; set; }
        public bool TieneMensajeDetraccion { get; set; }
        public bool TieneTransferenciaGratuita { get; set; }
        public bool TieneDocumentoRelacionado { get; set; }
        public bool TieneDescuentoGlobal { get; set; }
        public bool TieneOtrosCargosGlobal { get; set; }
        public bool TieneAnticipo { get; set; }
        public string CampoAdicional_01 { get; set; }
        public string CampoAdicional_02 { get; set; }
        public string CampoAdicional_03 { get; set; }
        public string CampoAdicional_04 { get; set; }
        public string CampoAdicional_05 { get; set; }
        public string CampoAdicional_06 { get; set; }
        public string CampoAdicional_07 { get; set; }
        public string CampoAdicional_08 { get; set; }
        public string CampoAdicional_09 { get; set; }
        public string CampoAdicional_10 { get; set; }
        public string CampoAdicional_11 { get; set; }
        public string CampoAdicional_12 { get; set; }
        public string CampoAdicional_13 { get; set; }
        public string CampoAdicional_14 { get; set; }
        public string CampoAdicional_15 { get; set; }
        public decimal TotalImpuestoBolsa { get; set; }
        public decimal TotalOtrosTributosGlobal { get; set; }
        public ClienteBe Cliente { get; set; }
        public FormaPagoBe FormaPago { get; set; }
        public List<ComprobanteDetalleBe> ListaDetalle { get; set; }
    }
}
