using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaDeportes_BE
{
    public class UsuarioBE
    {
        public Int16 id_usuario { get; set; }
        public String login_usuario { get; set; }
        public String password_usuario { get; set; }
        public Int16 nivel_usuario { get; set; }
        public Boolean estado_usuario { get; set; }
        public DateTime fecha_registro { get; set; }
        public String usu_registro { get; set; }

    }
}
