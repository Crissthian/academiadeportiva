using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaDeportes_BE
{
    public class EstudianteBE
    {
        public Int16 id { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        public String dni { get; set; }
        public Boolean estado { get; set; }
        public String telefono { get; set; }
        public String email { get; set; }
        public String sexo { get; set; }
        public String direccion { get; set; }
        public Int16 id_ubigeo { get; set; }
    }
}
