using hs.txt.be;
using IBM.Data.DB2;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hs.txt.da
{
    public class ComprobanteDa
    {
        public List<ComprobanteBe> ListarComprobantePorEstado(string estado, DB2Connection cn)
        {
            List<ComprobanteBe> list = null;

            using (DB2Command cmd = new DB2Command("", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new DB2Parameter { ParameterName = "estado", Direction = ParameterDirection.Input, DB2Type = DB2Type.VarChar, Size = -1, Value = estado });

                using (DB2DataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        list = new List<ComprobanteBe>();

                        ComprobanteBe item = new ComprobanteBe();

                        while (dr.Read())
                        {

                            list.Add(item);
                        }
                    }
                }
            }

            return list;
        }
    }
}
