using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class configuracion
    {
         static string _cadenaConexion = @"Data Source = DESKTOP-0K23KDM;Initial Catalog= Hospital; Integrated Security = true;";

        public static string CadenaConexion
        {
            get { return _cadenaConexion; }
        }

    }
}
