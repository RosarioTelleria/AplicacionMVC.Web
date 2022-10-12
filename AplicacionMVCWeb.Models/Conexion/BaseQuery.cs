using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace AplicacionMVCWeb.Models.Conexion
{
    public class BaseQuery
    {
        //guardado de la cadena de conexion internamente para las llamadas

        internal string _connectionString;

        public BaseQuery()
        {
            _connectionString = Environment.GetEnvironmentVariable("VAP_Demo_ConnStr");
        }

        public IDbConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }

        public class BaseResult
        {
            public bool Sucess { get; set; }
            public string? Message { get; set; }

            public int OBjetID { get; set; }

        }


    }
}
