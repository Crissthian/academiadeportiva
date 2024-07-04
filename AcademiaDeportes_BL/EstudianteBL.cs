using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Agregar...
using AcademiaDeportes_ADO;
using AcademiaDeportes_BE;

namespace AcademiaDeportes_BL
{
    public class EstudianteBL
    {
        EstudiantesADO objEstudiantesADO = new EstudiantesADO();

        public DataTable ListarEstudiante()
        {
            return objEstudiantesADO.ListarEstudiante();
        }





        public EstudianteBE ConsultarEstudiante(Int16 id)
        {
            return objEstudiantesADO.ConsultarEstudiante(id);
        }
        public Boolean InsertarEstudiante(EstudianteBE objEstudianteBE)
        {
            return objEstudiantesADO.InsertarEstudiante(objEstudianteBE);
        }

        public Boolean ActualizarEstudiante(EstudianteBE objEstudianteBE)
        {
            return objEstudiantesADO.ActualizarEstudiante(objEstudianteBE);
        }
        public Boolean EliminarEstudiante(Int16 id)
        {
            return objEstudiantesADO.EliminarEstudiante(id);
        }
    }
}
