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


        public static OracleDataReader ConsultaLeer(string cmdSQL)
        {
            OracleDataReader reader = null;
            if (ConexionAbrir())
            {
                var cmd = new OracleCommand();

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
;
            }
            return reader;
        }

        public static DataSet ConsultaDatos(string cmdSQL)
        {
            var adapter = new OracleDataAdapter();
            DataSet ds = new DataSet();

            if (ConexionAbrir())
            {
                var cmd = new OracleCommand();
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



        public static bool ConsultaNodata(string cmdSQL)
        {
            int lret = 0;

            if (ConexionAbrir())
            {
                var cmd = new OracleCommand();
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
        public static void ValidarSoloNumero(KeyPressEventArgs e)
        {
     
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan 
                e.Handled = true;
            }
        }

        public static void  ValidarSoloLetra (KeyPressEventArgs e)
        {

            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan 
                e.Handled = true;
            }
        }


        public static bool ValidarUsuario(string pnombre, string pclave)
        {
            bool lRet = false;
            string lpassword = "";
            int lidUsuario = 0;
           
            ConexionAbrir();
            if (ConexionAbrir())
            {
                OracleDataReader dr = ConsultaLeer("SELECT ID_USUARIO, USUARIO, CONTRASENA FROM USUARIOS WHERE USUARIOS.USUARIO='" + pnombre + "' AND USUARIOS.CONTRASENA='"+pclave+"'");
                if (dr != null)
                {
                    if (dr.Read())
                    {
                         lidUsuario = dr.GetInt32(0);  
                         lpassword = dr.GetString(2);

                        lRet = true;
                        // Asigno valor a propiedades de la clase.
                        loginName = pnombre;
                        idUsuario = lidUsuario;

                        // Cargo los permisos
                    }
                }
            }
            return lRet;
        }


        public static string SMensajes = ("Estas seguro que deseas Salir?");
        public static string ErrorSys = ("Favor Comunicarse con el Fryann Martinez ");
        public static string MensajeGuardar=("Información del Banco fue almacenada.");
        public static string MensajeEliminar = ("Seguro que quieres eliminar este Resgistro?");
        public static string MensajeActualizar = ("Su registro se ha actualizado");
        public static string ConfirmacionEliminar = ("Datos Elimnados Correctamente");
    }

}

        
        
        