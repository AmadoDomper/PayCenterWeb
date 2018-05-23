using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PayCenter.AccesoDatos.Helper
{
    public class Conexion
    {
        public static string cnsPayCenter = "cnsPayCenter";
        public static string cnsPayCenterSQL = ConfigurationManager.ConnectionStrings["cnsPayCenter"].ToString();
    }
}
