using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionOO.clases
{
    public class bc_Titulares_Cuentas : Mantenimientos
    {

        public int bc_Titular_Cuentaid { get; set; }
        public int bc_Cuenta_id { get; set; }
        public int bc_Cliente_id { get; set; }
        public string errormsg = "";



        public bc_Titulares_Cuentas(
            int pbc_Titular_Cuentaid,
            int pbc_Cuenta_id,
            int pbc_Cliente_id)

        {
            this.bc_Titular_Cuentaid = pbc_Titular_Cuentaid;
            this.bc_Cuenta_id = pbc_Cuenta_id;
            this.bc_Cliente_id = pbc_Cliente_id;

        }

        public bc_Titulares_Cuentas()
        {
            Limpiar();
        }
        public void Limpiar()
        {
            bc_Titular_Cuentaid = 0;
            bc_Cuenta_id = 0;
            bc_Cliente_id = 0;
        }


        public bool Validar()
        {
            bool lret = true;

            if (lret && bc_Titular_Cuentaid.Equals(""))
            {
                errormsg = "Nombre de Banco no puede estar vacío.";
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
                    bc_Titular_Cuentaid = Convert.ToInt16(dr["id_titular_cuenta"]);
                    bc_Cuenta_id = Convert.ToInt16(dr["id_cuenta"]);
                    bc_Cliente_id = Convert.ToInt16(dr["id_cliente"]);

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
            bc_Titular_Cuentaid = 0;

            if (datamanager.ConexionAbrir())
            {

                OracleCommand cmd = new OracleCommand("Insert into bc_titulares_cuentas" +
                 "(id_titular_cuenta,id_cuenta,id_cliente)" +
                 " Values(:id_titular_cuenta,:id_cuenta,:id_cliente)", datamanager.ConexionSQL);

                cmd.Parameters.AddWithValue("id_titular_cuenta", bc_Titular_Cuentaid);
                cmd.Parameters.AddWithValue("id_cuenta", bc_Cuenta_id);
                cmd.Parameters.AddWithValue("id_cliente", bc_Cliente_id);

                datamanager.ConexionAbrir();
                bc_Titular_Cuentaid = (int)cmd.ExecuteNonQuery();

                datamanager.ConexionCerrar();

            }
            return bc_Titular_Cuentaid;
        }


       public bool Buscar(String pNombre, bool asignar)
        {
            var dr = datamanager.ConsultaLeer("select id_titular_cuenta, id_cuenta,id_cliente" +
                                               " from bc_titulares_cuentas" +
                                               " where id_titular_cuenta = '" + pNombre + "'");
            return LeerDatos(dr, asignar);

        }

        public bool Buscar(int Titulaa, bool asignar)
        {
            var dr = datamanager.ConsultaLeer("select id_titular_cuenta, id_cuenta,id_cliente" +
                                               " from bc_titulares_cuentas" +
                                               " where id_titular_cuenta = '" + bc_Titular_Cuentaid.ToString() + "'");

            return LeerDatos(dr, asignar);
        }

        public bool BuscarUltimo()

        {
            var dr = datamanager.ConsultaLeer(" Select id_titular_cuenta,id_cuenta, id_cliente" +
                                              " From bc_titulares_cuentas" +
                                              " Order by id_titular_cuenta desc ");
            return LeerDatos(dr, true);
        }








        public bool ActualizarDatos()
        {
            int lRet = 0;

            if (datamanager.ConexionAbrir())
            {
                OracleCommand cmd = new OracleCommand(" Update bc_titulares_cuentas" +
                                                     " Set id_titular_cuenta = :id_titular_cuenta," +
                                                      " id_cuenta = :id_cliente," +
                                                      " id_cliente = :id_cliente," +

                                                      " Where id_titular_cuenta = :id_cliente ", datamanager.ConexionSQL);

                cmd.Parameters.AddWithValue("id_titular_cuenta", bc_Titular_Cuentaid);
                cmd.Parameters.AddWithValue("id_cuenta", bc_Cuenta_id);
                cmd.Parameters.AddWithValue("id_cliente", bc_Cliente_id);
               
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



       


      
    }
}
