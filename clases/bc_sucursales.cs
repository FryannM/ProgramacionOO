using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionOO.clases
{
    class bc_sucursales : Mantenimientos
    {



        public int bc_id_Sucursal { get; set; }
        public int bc_id_Banco { get; set; }
        public string bc_Codigo { get; set; }
        public string bc_Nombre { get; set; }
        public string bc_Direccion { get; set; }
        public string bc_Telefono { get; set; }
        public string bc_Correo { get; set; }
        public string bc_NombreBanco { get; set; }


        public bc_sucursales(int pbc_id_Sucursal,int
            pbc_id_Banco,
            string pbc_Codigo,
            string pbc_Nombre,
            string pbc_Direccion,
            string pbc_Telefono,
            string pbc_Correo,
            string pbc_nombreBanco
            )


        {
            this.bc_id_Sucursal = pbc_id_Sucursal;
            this.bc_id_Banco = pbc_id_Banco;
            this.bc_NombreBanco = pbc_nombreBanco;
            this.bc_Codigo = pbc_Codigo;
            this.bc_Nombre = pbc_Nombre;
            this.bc_Direccion = pbc_Direccion;
            this.bc_Telefono = pbc_Telefono;
            this.bc_Correo = pbc_Correo;
        }
        public bc_sucursales()
        {
            Limpiar();
        }
        public void Limpiar()
        {

            bc_id_Sucursal = 0;
            bc_id_Banco = 0;
            bc_Nombre = "";
            bc_Direccion = "";
            bc_Telefono = "";
            bc_Correo = "";


        }
        public bool Validar()
        {
            bool lret = true;

            if (lret && bc_Nombre.Equals(""))
            {
                lret = false;
            }

            return lret;
        }


        public bool LeerDatos(OracleDataReader dr, bool asignar)
        {
            bool encontrado = false;
            if (dr.Read())
            {
                encontrado = true;
                if (asignar)
                {
                    bc_id_Sucursal = Convert.ToInt16(dr["id_Sucursal"]);
                    bc_id_Banco = Convert.ToInt16(dr["id_banco"]);
                 //  bc_NombreBanco = dr["Nombre  "].ToString();
                    bc_Codigo = dr["codigo"].ToString();
                    bc_Direccion = dr["direccion"].ToString();
                  bc_Nombre = dr["nombre"].ToString();
                    bc_Telefono = dr["telefono"].ToString();
                    bc_Correo = dr["correo"].ToString();

                }
            }
            else
            {
                if (asignar) Limpiar();
            }

            return encontrado;
        }





        public int CrearDatos()
        {

            bc_id_Banco = 0;

            if (datamanager.ConexionAbrir())
            {



                var cmd = new OracleCommand("Insert into bc_sucursales(Id_Banco,Codigo,Nombre ,Direccion,Telefono,Correo)" +
                                                        " Values(:Id_Banco,:Codigo,:Nombre,:Direccion,:Telefono,:Correo)", datamanager.ConexionSQL);

                cmd.Parameters.AddWithValue("id_banco", bc_id_Banco);
                cmd.Parameters.AddWithValue("codigo", bc_Codigo);
                cmd.Parameters.AddWithValue("nombre", bc_Nombre);
                cmd.Parameters.AddWithValue("direccion", bc_Direccion);
                cmd.Parameters.AddWithValue("Telefono", bc_Telefono);
                cmd.Parameters.AddWithValue("Correo", bc_Correo);

                datamanager.ConexionAbrir();
                bc_id_Banco = (int)cmd.ExecuteNonQuery();

                datamanager.ConexionCerrar();

            }
            return bc_id_Banco;
        }

        public bool BuscarUltimo()
        {
            //var dr = datamanager.ConsultaLeer(" SELECT bc_sucursales.ID_SUCURSAL," +
            //                                  "  bc_sucursales.id_banco,bc_bancos.nombre, " +
            //                                  "  bc_sucursales.codigo," +
            //                                  "  bc_sucursales.direccion," +
            //                                  "  bc_sucursales.telefono," +
            //                                  "  bc_sucursales.Correo from bc_sucursales" +
            //                                  "  INNER  JOIN  bc_bancos" +
            //                                  "  ON  bc_bancos.BANCOID = bc_sucursales.ID_BANCO" +
            //                                  "  ORDER BY bc_sucursales.ID_SUCURSAL desc");


            var dr = datamanager.ConsultaLeer(" Select id_sucursal,id_banco,codigo,Nombre,direccion,telefono ,correo" +
                             " From bc_sucursales" +
                        " Order by id_sucursal desc");

            return LeerDatos(dr, true);
        }



        public bool ActualizarDatos()
        {
            int lRet = 0;

            if (datamanager.ConexionAbrir())
            {

                //(Id_Banco,Codigo,Nombre ,Direccion,Telefono,Correo)" +
                var cmd = new OracleCommand(" Update bc_sucursales" +
                                                      " Set id_sucursal = id_sucursal" +
                                                      " Id_Banco = :Id_Banco," +
                                                      " Codigo = :Codigo," +
                                                      " Nombre = :Nombre," +
                                                      " Direccion = :Direccion, " +
                                                      " Telefono = :Telefono " +
                                                      " Correo = :Correo " +
                                                      " Where id_sucursal = :id_sucursal ", datamanager.ConexionSQL);

                cmd.Parameters.AddWithValue("id_sucursal", bc_id_Sucursal);
                cmd.Parameters.AddWithValue("Id_Banco", bc_id_Banco);
                cmd.Parameters.AddWithValue("Codigo", bc_Codigo);
                cmd.Parameters.AddWithValue("Nombre", bc_Nombre);
                cmd.Parameters.AddWithValue("Direccion", bc_Direccion);
                cmd.Parameters.AddWithValue("Telefono", bc_Telefono);
                cmd.Parameters.AddWithValue("Correo", bc_Correo);
                datamanager.ConexionAbrir();
                cmd.ExecuteNonQuery();
                datamanager.ConexionCerrar();
            }
            return lRet > 0;
        }

        public bool BorrarDatos(int pbancoid)
        {
            throw new NotImplementedException();
        }

        public bool Buscar(string Param, bool asignar)
        {
            throw new NotImplementedException();
        }

        public bool Buscar(int Param, bool asignar)
        {
            throw new NotImplementedException();
        }

    }
}
