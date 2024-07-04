using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AcademiaDeportes_ADO;
using AcademiaDeportes_BE;

namespace AcademiaDeportes_BL
{
    public class InstructorBL
    {
        InstructorADO objInstructorADO = new InstructorADO();
            
        public DataTable ListarInstructor()
        {
            return objInstructorADO.ListarInstructor();
        }
        public InstructorBE ConsultarInstructor(Int16 id)
        {
            return objInstructorADO.ConsultarInstructor(id);
        }

        public Boolean InsertarInstructor(InstructorBE objInstructorBE)
        {
            return objInstructorADO.InsertarInstructor(objInstructorBE);
        }
        public Boolean ActualizarInstructor(InstructorBE objInstructorBE)
        {
            return objInstructorADO.ActualizarInstructor(objInstructorBE);
        }
        public Boolean EliminarInstructor(Int16 id)
        {
            return objInstructorADO.EliminarInstructor(id);
        }
    }
}
