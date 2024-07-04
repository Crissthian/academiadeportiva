using AcademiaDeportes_ADO;
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
    public class SedesBL
    {
        SedesADO objSedesADO = new SedesADO();
        public DataTable ListarSedes()
        {
            return objSedesADO.ListarSedes();
        }

        public SedesBE consultarSede(Int16 id)
        {
            return objSedesADO.consultarSede(id);
        }

        public Boolean InsertarSede(SedesBE objSedesBE)
        {
            return objSedesADO.InsertarSede(objSedesBE);
        }


        public Boolean ActualizarSede(SedesBE objSedesBE)
        {
            return objSedesADO.ActualizarSede(objSedesBE);
        }

        public Boolean EliminarSede(Int16 id)
        {
            return objSedesADO.EliminarSede(id);
        }


    }
}
