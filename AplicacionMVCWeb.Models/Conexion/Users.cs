using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
namespace AplicacionMVCWeb.Models.Conexion
{
    public  class Users: BaseQuery
    {
        public Users() : base() { }
        //mostrar todos los usuarios en la tabla 
        //return lista de usuarios

        public List<User> GetAll()
        {
            var users=new List<User>();
            using (var db = GetConnection())
            {
                users = db.Query<User>(@"SELECT * FROM[User]").ToList();

            }
            return users;
        }

    }
}
