using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hs.txt.be
{
    public class FormaPagoBe
    {
        public string FormaPagoIdDiferencial { get; set; }
        public string Tipo { get; set; }
        public decimal MontoPendientePago { get; set; }
        public DateTime FechaPago { get; set; }
        public bool TieneCuotas { get; set; }
        public List<FormaPagoDetalleBe> ListaFormaPagoDetalle { get; set; }
    }
}
