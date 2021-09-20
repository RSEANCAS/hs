using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hs.txt.be
{
    public class ComprobanteDetalleBe
    {
        public int ComprobanteDetalleId { get; set; }
        public string TipoItem { get; set; }
        public string TipoAfectacionIgv { get; set; }
        public string UnidadMedida { get; set; }
        public string CodigoInterno { get; set; }
        public string CodigoProductoSunat { get; set; }
        public string Descripcion { get; set; }
        public decimal Cantidad { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal Descuento { get; set; }
        public decimal PorcentajeDescuento { get; set; }
        public decimal BaseImponible { get; set; }
        public decimal Igv { get; set; }
        public decimal Isc { get; set; }
        public decimal PorcentajeIsc { get; set; }
        public decimal OtrosCargos { get; set; }
        public decimal PorcentajeOtrosCargos { get; set; }
        public decimal OtrosTributos { get; set; }
        public decimal PorcentajeOtrosTributos { get; set; }
        public decimal ImporteTotal { get; set; }
    }
}
