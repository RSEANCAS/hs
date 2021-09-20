using hs.txt.be;
using hs.txt.da;
using IBM.Data.DB2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hs.txt.bl
{
    public class ComprobanteBl : Conexion
    {
        ComprobanteDa comprobanteDa = new ComprobanteDa();

        public List<ComprobanteBe> ListarComprobantePorEstado(string estado)
        {
            List<ComprobanteBe> lista = null;

            try
            {
                using (DB2Connection cn = new DB2Connection(cnString))
                {
                    cn.Open();
                    lista = comprobanteDa.ListarComprobantePorEstado(estado, cn);
                    cn.Close();
                }
            }
            catch (Exception ex) { throw ex; }

            return lista;
        }
    }
}
