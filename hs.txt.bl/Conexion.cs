using hs.txt.ut;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hs.txt.bl
{
    public class Conexion
    {
        static string cnName = AppSettings.Get<string>("cn.name");
        protected string cnString = ConfigurationManager.ConnectionStrings[cnName].ConnectionString;
    }
}
