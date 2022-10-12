using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionMVCWeb.Models
{
    //mapeo de tabla User
    public class User
    {
            public int ID { get; set; }

            public int RoleID { get; set; }

            public string? Email { get; set; }

            public int? Age { get; set; }

            public bool IsActive { get; set; }

            public DateTimeOffset RecordDate { get; set; }

            public decimal Balance { get; set; }

        }
    }

