﻿using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionOO.clases
{
    interface IMantenimientos
    {

        bool LeerDatos(OracleDataReader dr, bool asignar);
        void Limpiar();
        bool BuscarUltimo();
        bool Validar();
        int CrearDatos();
        bool ActualizarDatos();
        bool BorrarDatos(int pbancoid);
        bool BorrarDatos(string codigo);
        bool Buscar(String Param, bool asignar);
        bool Buscar(int Param, bool asignar);

    }
}
