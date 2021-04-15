using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreRDLCMatrix.Web.Models
{
    public class ConnectionString
    {
        private static string cName = "Data Source=david-pc;Initial Catalog=AdultosMayores;Integrated Security=True";
        public static string CName { get => cName; }
    }
}
