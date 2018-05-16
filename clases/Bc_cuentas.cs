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
    class bc_cuentas :Mantenimientos
    {
        public string CodigoCuenta { get; set; }
        public char Estado { get; set; }
        public double BalanceDB { get; set; }
        public double BalanceCR { get; set; }


        public bc_cuentas() {

        }

        public bc_cuentas (string CodigoCuenta, char Estado, double BanlanceDB,double BalanceCR) 
        {
            this.CodigoCuenta = CodigoCuenta;
            this.Estado = Estado;
            this.BalanceDB = BalanceDB;
            this.BalanceCR = BalanceCR;

        }

        public void Limpiar()
        {
            CodigoCuenta = "";
            Estado = ' ';
            BalanceDB = 0;
            BalanceCR=0;
        }

        public bool Validar()
        {
            bool lret = true;

            if (lret && CodigoCuenta.Equals(""))
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

        public bool Buscar(String pNombre, bool asignar)
        {
             var dr = datamanager.ConsultaLeer("select id_cuenta, codigo,estado,balance_DB" +
                                               " from Bc_cuentas" +
                                               " where Nombre = '" + pNombre + "'");
            return LeerDatos(dr, asignar);

        }

        //Optimizar luego, metodo para filtrar informacion en un DataGridView implementacion: nombreGridView.DataSource=BuscarCuenta();
        public virtual DataTable BuscarCuentas(string campo, string palabras)
        {

            OracleConnection conx = new OracleConnection(datamanager.cadenadeconexion);
            conx.Open();
            OracleCommand cm = conx.CreateCommand();
            cm.CommandType = CommandType.Text;
            cm.CommandText = "select * from Bc_cuentas where " + campo+ " like '" + palabras + "%'";
            cm.ExecuteNonQuery();
            conx.Close();
            return LlenarDataGridView(cm);
 
        }

        public bool BuscarUltimo()

        {
            var dr = datamanager.ConsultaLeer(" Select codigo,estado,balance_DB,balance_CR" +
                                              " From Bc_cuentas" +
                                              " Order by id_cuenta desc ");
            return LeerDatos(dr, true);
        }

        public int CrearDatos()
        {
            int filasAfectadas=0;
            

            if (datamanager.ConexionAbrir())
            {



                OracleCommand cmd = new OracleCommand("Insert into Bc_cuentas(codigo,estado,balance_DB,balance_CR)" +
                                                        " Values(:codigo,"+"'"+Estado+"'"+",:balance_DB,:balance_CR)", datamanager.ConexionSQL);

                
                cmd.Parameters.AddWithValue("codigo", CodigoCuenta);
                cmd.Parameters.AddWithValue("balance_DB", BalanceDB);
                cmd.Parameters.AddWithValue("balance_CR", BalanceCR);
                

                datamanager.ConexionAbrir();

                try
                {
                    filasAfectadas = cmd.ExecuteNonQuery();
                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
                datamanager.ConexionCerrar();

            }
            return filasAfectadas;

        }

        public virtual bool BorrarDatos(int codigoCuenta)
        {
            throw new NotImplementedException(); //No estamos trabajando con id de la tabla.
        } 

        public virtual bool BorrarDatos(string CodigoCuenta)//Sobrecarga  del metodo BorrarDatos
        {
            bool lret = datamanager.ConsultaNodata("delete from Bc_cuentas where " +
                                                   "codigo = '"+CodigoCuenta+"'");

            if (lret)
            {

             Limpiar();

            }


            return lret;
        }

        public bool ActualizarDatos()
        {
            int lRet = 0;

            if (datamanager.ConexionAbrir())
            {
                OracleCommand cmd = new OracleCommand(" Update Bc_cuentas" +
                                                      " Set Estado = '"+Estado+"'," +
                                                      " Balance_DB = :Balance_DB," +
                                                      " Balance_CR = :Balance_CR"+
                                                      " Where Codigo= :Codigo", datamanager.ConexionSQL);

                
                cmd.Parameters.AddWithValue("Codigo",CodigoCuenta );
                cmd.Parameters.AddWithValue("Balance_DB", BalanceDB);
                cmd.Parameters.AddWithValue("Balance_CR", BalanceCR);
                datamanager.ConexionAbrir();
                cmd.ExecuteNonQuery();
                datamanager.ConexionCerrar();

                lRet = 1;
            }
            return lRet > 0;
        }

        public bool BuscarCodigo(String Codigo)
        {
            var dr = datamanager.ConsultaLeer("select codigo from Bc_cuentas where codigo = '" + Codigo.ToString() + "'");


            return LeerDatos(dr, false);
        }

        public bool Buscar(int Bancoid, bool asignar)
        {
            throw new NotImplementedException();
        }

        public virtual DataTable LlenarDataGridView(OracleCommand cSQL)
        {
            DataTable dt = new DataTable();
            OracleDataAdapter adp = new OracleDataAdapter(cSQL);
            adp.Fill(dt);
            return dt;
        }
    }

}
