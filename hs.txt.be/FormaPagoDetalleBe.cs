using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hs.txt.be
{
    public class FormaPagoDetalleBe
    {
        public string FormaPagoDetalleIdDiferencial { get; set; }
        public string FormaPagoDetalleId { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaPago { get; set; }
    }
}
