using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaDeportes_BE
{
    public class SedesBE
    {
        public Int16 id { get; set; }
        public String nombre { get; set; }
        public Int16 capacidad { get; set; }
        public String director { get; set; }
        public Int16 id_ubigeo { get; set; }
        public String direccion { get; set; }

    }
}
