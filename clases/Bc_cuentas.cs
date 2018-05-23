using System.Data.OracleClient;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProgramacionOO.clases
{
    class bc_cuentas : bc_bancos
        {

        #region ATRIBUTOS
        public string CodigoCuenta { get; set; }
        public char Estado { get; set; }
        public double BalanceDB { get; set; }
        public double BalanceCR { get; set; }
        #endregion

        #region CONSTRUCTORES
        public bc_cuentas()
        {

        }

        public bc_cuentas(string CodigoCuenta, char Estado, double BanlanceDB, double BalanceCR)
        {
            this.CodigoCuenta = CodigoCuenta;
            this.Estado = Estado;
            this.BalanceDB = BalanceDB;
            this.BalanceCR = BalanceCR;

        }

        #endregion

        #region METODOS Y FUNCIONES
        public override void Limpiar()
        {
            CodigoCuenta = "";
            Estado = ' ';
            BalanceDB = 0;
            BalanceCR = 0;
        }

        public override bool Validar()
        {
            bool lret = true;

            if (lret && CodigoCuenta.Equals(""))
            {
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

                    CodigoCuenta = dr["codigo"].ToString();
                    Estado = Convert.ToChar(dr["estado"]);
                    BalanceDB = Convert.ToDouble(dr["balance_DB"]);
                    BalanceCR = Convert.ToDouble(dr["balance_CR"]);
                }
            }
            else
            {
                if (asignar) Limpiar();
            }

            return encontrado;
        }

        public override bool Buscar(String pNombre, bool asignar)
        {
            var dr = datamanager.ConsultaLeer("select id_cuenta, codigo,estado,balance_DB" +
                                              " from Bc_cuentas" +
                                              " where Nombre = '" + pNombre + "'");
            return LeerDatos(dr, asignar);

        }

        public override bool BuscarUltimo()

        {
            var dr = datamanager.ConsultaLeer(" Select codigo,estado,balance_DB,balance_CR" +
                                              " From Bc_cuentas" +
                                              " Order by id_cuenta desc ");
            return LeerDatos(dr, true);
        }

        public override int CrearDatos()
        {
            int filasAfectadas = 0;

            if (datamanager.ConexionAbrir())
            {

                var cmd = new OracleCommand(" Insert into Bc_cuentas(" +
                                            " codigo,estado,balance_DB,balance_CR)" +
                                            " Values(:codigo," + "'" + Estado + "'" +
                                            ",:balance_DB,:balance_CR)", datamanager.ConexionSQL);


                cmd.Parameters.AddWithValue("codigo", CodigoCuenta);
                cmd.Parameters.AddWithValue("balance_DB", BalanceDB);
                cmd.Parameters.AddWithValue("balance_CR", BalanceCR);

                datamanager.ConexionAbrir();
                filasAfectadas = cmd.ExecuteNonQuery();
                datamanager.ConexionCerrar();

            }
            return filasAfectadas;
        }

        public override bool BorrarDatos(string CodigoCuenta)
        {
            bool lret = datamanager.ConsultaNodata("delete from Bc_cuentas where " +
                                                   "codigo = '" + CodigoCuenta + "'");

            if (lret)
            {

                Limpiar();

            }

            return lret;
        }

        public override bool ActualizarDatos()
        {
            int lRet = 0;

            if (datamanager.ConexionAbrir())
            {
                var cmd = new OracleCommand(" Update Bc_cuentas" +
                                                      " Set Estado = '" + Estado + "'," +
                                                      " Balance_DB = :Balance_DB," +
                                                      " Balance_CR = :Balance_CR" +
                                                      " Where Codigo= :Codigo", datamanager.ConexionSQL);


                cmd.Parameters.AddWithValue("Codigo", CodigoCuenta);
                cmd.Parameters.AddWithValue("Balance_DB", BalanceDB);
                cmd.Parameters.AddWithValue("Balance_CR", BalanceCR);
                datamanager.ConexionAbrir();
                cmd.ExecuteNonQuery();
                datamanager.ConexionCerrar();

                lRet = 1;
            }
            return lRet > 0;
        }

        public virtual DataTable BuscarCuentas(string campo, string palabras)
        {
            var cm = new OracleCommand();

            if (datamanager.ConexionAbrir())


            {

                cm = datamanager.ConexionSQL.CreateCommand();
                cm.CommandType = CommandType.Text;
                cm.CommandText = "select * from Bc_cuentas where " + campo + " like '" + palabras + "%'";
                cm.ExecuteNonQuery();
                datamanager.ConexionCerrar();
            }


            return LlenarDataGridView(cm);
        }

        public virtual DataTable verTodasCuentas()
        {
            var cm = new OracleCommand();

            if (datamanager.ConexionAbrir())


            {

                cm = datamanager.ConexionSQL.CreateCommand();
                cm.CommandType = CommandType.Text;
                cm.CommandText = "select * from Bc_cuentas";
                cm.ExecuteNonQuery();
                datamanager.ConexionCerrar();
            }


            return LlenarDataGridView(cm);

        }

        public virtual bool BuscarCodigo(String Codigo)
        {
            var dr = datamanager.ConsultaLeer("select codigo from Bc_cuentas where codigo = '" + Codigo.ToString() + "'");
            return LeerDatos(dr, false);
        }

        public virtual DataTable LlenarDataGridView(OracleCommand cSQL)
        {
            DataTable dt = new DataTable();
            var adp = new OracleDataAdapter(cSQL);
            adp.Fill(dt);
            return dt;
        }

        #endregion
    }

}
