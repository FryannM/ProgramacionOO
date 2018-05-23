using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramacionOO.clases
{
    class bc_Titulares_Cuentas : bc_clientes
    {
        #region ATRIBUTOS
        public int bc_Titular_Cuentaid { get; set; }
        public int bc_Cuenta_id { get; set; }
        public int bc_Cliente_id { get; set; }
        public string bc_nombreCliente { get; set; }
        public string bc_codigoCuenta { get; set; }
        new public string errormsg = "";
        #endregion

        #region CONSTRUCTORES
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

        #endregion

        #region METODOS Y FUNCIONES
        public override void Limpiar()
        {
            bc_Titular_Cuentaid = 0;
            bc_Cuenta_id = 0;
            bc_Cliente_id = 0;
        }


        public override bool Validar()
        {
            bool lret = true;

            if (lret && bc_Titular_Cuentaid.Equals(""))
            {
                errormsg = "Nombre de Banco no puede estar vacío.";
                lret = false;
            }
            return lret;
        }


        public override bool LeerDatos(OracleDataReader dr, bool asignar)
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
                    bc_nombreCliente = (dr["NOMBRE"]).ToString();
                    bc_codigoCuenta = (dr["codigo"]).ToString();

                }
            }
            else
            {
                if (asignar) Limpiar();
            }

            return encontrado;
        }


        public override int CrearDatos()
        {
            bc_Titular_Cuentaid = 0;

            if (datamanager.ConexionAbrir())
            {

                var cmd = new OracleCommand("Insert into bc_titulares_cuentas" +
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


        public override bool Buscar(String pNombre, bool asignar)
        {
            var dr = datamanager.ConsultaLeer("select id_titular_cuenta, id_cuenta,id_cliente" +
                                               " from bc_titulares_cuentas" +
                                               " where id_titular_cuenta = '" + pNombre + "'");
            return LeerDatos(dr, asignar);

        }

        public override bool Buscar(int Titulaa, bool asignar)
        {
            var dr = datamanager.ConsultaLeer("select id_titular_cuenta, id_cuenta,id_cliente" +
                                               " from bc_titulares_cuentas" +
                                               " where id_titular_cuenta = '" + bc_Titular_Cuentaid.ToString() + "'");

            return LeerDatos(dr, asignar);
        }

        public override bool BuscarUltimo()

        {
            var dr = datamanager.ConsultaLeer("  Select bc_titulares_cuentas.id_titular_cuenta,bc_cuentas.codigo,bc_clientes.NOMBRE," +
                                               " bc_titulares_cuentas.id_cuenta, bc_titulares_cuentas.id_cliente" +
                                               " From bc_titulares_cuentas" +
                                               " INNER JOIN bc_cuentas" +
                                               " on bc_titulares_cuentas.ID_CUENTA = bc_cuentas.id_cuenta" +
                                               " INNER JOIN bc_clientes" +
                                               " on bc_titulares_cuentas.ID_CLIENTE = bc_clientes.ID_CLIENTE" +
                                               " Order by id_titular_cuenta desc");
            return LeerDatos(dr, true);
        }

        public override bool ActualizarDatos()
        {
            int lRet = 0;

            if (datamanager.ConexionAbrir())
            {
                var cmd = new OracleCommand(" Update bc_titulares_cuentas" +
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

        public override bool BuscarCodigo(string Codigo)
        {
            var  dr = datamanager.ConsultaLeer("select codigo from bc_titulares_cuentas where ID_TITULAR_CUENTA = '" + Codigo.ToString() + "'");



            return LeerDatos(dr, false); 

         
        }

        public override void SelectComboBox(ComboBox cb)
        {
            var dr = datamanager.ConsultaLeer(LlenarCB_Clientes.ToString());

            while (dr.Read())
            {
                cb.Items.Add(dr[0].ToString() + " - " + dr[1].ToString());
            }
        }



        #endregion
    }
}
