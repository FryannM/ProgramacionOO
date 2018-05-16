using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Configuration;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Data.OracleClient;


namespace ProgramacionOO
{
    public static class datamanager
    {
        public static OracleConnection ConexionSQL;
      

        /// <summary>
        /// <para>Cadena de conexión a la base de datos extraida del archivo App.config.</para>
        /// </summary>
        public static string cadenadeconexion
        {
            get
            {

                return ConfigurationManager.ConnectionStrings["DbOracle"].ConnectionString;
            }
            private set { }
        }

        public static string loginName { get; private set; }
        public static int idUsuario { get; private set; }
        public static string Estado { get; set; }


        public static bool ConexionAbrir()
        {
            bool ret = true;
            try
            {
                ConexionSQL = new OracleConnection(cadenadeconexion);
                ConexionSQL.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ret = false;
            }
            return ret;
        }
        // Fin ConexionAbrir

        public static bool ConexionCerrar()
        {
            bool ret = true;
            try
            {
                if (ConexionSQL.State == System.Data.ConnectionState.Open)
                    ConexionSQL.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ret = false;
            }
            return ret;
        }
        // Fin ConexionCerra

        public static OracleDataReader ConsultaLeer(string cmdSQL)
        {
            OracleDataReader reader = null;
            if (ConexionAbrir())
            {
                OracleCommand cmd = new OracleCommand();

                try
                {
                    cmd.CommandText = cmdSQL;
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = ConexionSQL;
                    reader = cmd.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    reader = null;
                }
                //ConexionCerrar();
            }
            return reader;
        }
        // Fin ConsultaLeer

        public static DataSet ConsultaDatos(string cmdSQL)
        {
            OracleDataAdapter adapter = new OracleDataAdapter();
            DataSet ds = new DataSet();

            if (ConexionAbrir())
            {
                OracleCommand cmd = new OracleCommand();
                try
                {
                    cmd.Connection = ConexionSQL;
                    cmd.CommandText = cmdSQL;
                    adapter.SelectCommand = cmd;
                    adapter.Fill(ds);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    ds = null;
                }
                ConexionCerrar();
            }
            return ds;
        }
        // Fin ConsultaDatos


        public static bool ConsultaNodata(string cmdSQL)
        {
            int lret = 0;

            if (ConexionAbrir())
            {
                OracleCommand cmd = new OracleCommand();
                try
                {
                    cmd.Connection = ConexionSQL;
                    cmd.CommandText = cmdSQL;

                    lret = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                ConexionCerrar();
            }
            return (lret > 0);
        }
      


        public static bool ValidarUsuario(string pnombre, string pclave /*string Estatus*/)
        {
            bool retorno = false;
            string lpassword = "";
            int lidUsuario = 0;
           

            if (ConexionAbrir())
            {
                var dr = ConsultaLeer("Select Usuario_id,Contrasena From Usuarios Where Nombre_Usuario='" + pnombre + "'");
                if (dr != null)
                {
                    if (dr.Read())
                    {
                        lidUsuario = dr.GetInt32(0);
                        lpassword = dr.GetString(1);


                        retorno = true;
                            // Asigno valor a propiedades de la clase.
                            loginName = pnombre;
                            idUsuario = lidUsuario;

                            // Cargo los permisos
                        
                    }
                }
            }
            return retorno;
        }

        public static void LoadDataBanco(string sql)
        {
            if (ConexionAbrir()) 
            try
            {
                
                OracleCommand cmd = new OracleCommand(sql,ConexionSQL);
                OracleDataReader dr = cmd.ExecuteReader();


                if (dr.HasRows)
                {
                    MessageBox.Show("Ya se ha pasado Asistencia en el dia de HOY  ", "ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    return;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            datamanager.ConexionCerrar();
        }



        // Mensajes del sistema 
        public static string SMensajes = ("Estas seguro que deseas Salir?");
        public static string ErrorSys = ("Favor Comunicarse con el Fryann Martinez ");
        public static string MensajeGuardar=("Información del Banco fue almacenada.");
        public static string MensajeEliminar = ("Seguro que quieres eliminar este Resgistro?");
        public static string ConfirmacionEliminar = ("Datos Elimnados Correctamente");
    }

}

        
        
        