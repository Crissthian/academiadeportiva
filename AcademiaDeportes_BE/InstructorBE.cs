using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaDeportes_BE
{
    public class InstructorBE
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string especialidad { get; set; }
        public string DNI { get; set; }
        public short id_ubigeo { get; set; }
        public string direccion { get; set; }
        public string teléfono { get; set; }
        public string correo { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        public DateTime fecha_ingreso { get; set; }
        
    }
}

