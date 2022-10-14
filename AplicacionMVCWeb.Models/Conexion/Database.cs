using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionMVCWeb.Models.Conexion
{
    public  class Database
    {
        public Users Users { get; set; }
        public Database()
        {
            Users = new Users();
        }
    }
}
