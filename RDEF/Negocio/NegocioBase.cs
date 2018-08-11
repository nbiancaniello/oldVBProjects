using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Configuration;

namespace Negocio
{
    public class NegocioBase
    {
        /// <summary>
        /// Obtiene la cadena de conexion connectionStringODBC del archivo de configuracion
        /// </summary>
        /// <returns></returns>
        public static String getConnectionString()
        {
            AppSettingsReader connectionConfig = new AppSettingsReader();
            return (string)connectionConfig.GetValue("connectionStringODBC", typeof(string));
        }
    }
}
