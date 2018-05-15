using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionOO.clases
{
    interface Mantenimientos
    {

         bool LeerDatos(OracleDataReader dr, bool asignar);
         void Limpiar();
         bool BuscarUltimo();
         bool Validar();
         int  CrearDatos();
         bool ActualizarDatos();
         bool BorrarDatos(int pbancoid);
         bool Buscar(String Param, bool asignar);
         bool Buscar(int Param, bool asignar);
        
    }
}
