using System;
using Modelo;

namespace Controler
{
    public class TestConexion
    {
        datamanager objManager= new datamanager();

        public void ValidarConexion()
        {
            if (objManager.ConexionAbrir())
            {
                Console.WriteLine("La conexion fue exitosa");
            }
            else 
            {
                Console.WriteLine("La conexion a DB no fue realizada");

            }
           
        }
    }
}
