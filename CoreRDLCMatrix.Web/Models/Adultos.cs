using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreRDLCMatrix.Web.Models
{
    public class Adultos
    {
        public int id { get; set; }

        public string Adulto { get; set; }

        public string Efector { get; set; }

        public string zona { get; set; }

        public string DNI { get; set; }

        public string Diab { get; set; }

        public string Hip { get; set; }

        public string Covid { get; set; }

        public DateTime fechaUltimoContacto { get; set; }

        public string estadoPaciente { get; set; }
    }
}
