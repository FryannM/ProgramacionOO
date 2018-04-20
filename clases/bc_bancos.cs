using System;
using System.Collections.Generic;
using System.Data.OracleClient;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionOO.clases
{
    class bc_bancos
    {


        #region Atributos

        public int bc_bancoid = 0;
        public string bc_bancoCodigo { get; set; }
        public string bc_bancoNombre { get; set; }
        public string bc_bancoDireccion { get; set; }
        public string bc_bancoRnc { get; set; }
        public string errormsg = "";

        #endregion



        #region Constructores
        public bc_bancos()
        {
            limpiar();
        }

        public bc_bancos(
            int pbc_bancoid,
            string pbc_bancoCodigo,
            string pbc_bancoNombre,
            string pbc_bancoDireccion,
            string pbc_bancoRnc)

        {
            this.bc_bancoid = pbc_bancoid;
            this.bc_bancoCodigo = pbc_bancoCodigo;
            this.bc_bancoNombre = pbc_bancoNombre;
            this.bc_bancoDireccion = pbc_bancoDireccion;
            this.bc_bancoRnc = pbc_bancoRnc;


        }

        #endregion

        #region Métodos y funciones


        public void limpiar()
        {
            bc_bancoid = 0;
            bc_bancoNombre = "";
            bc_bancoDireccion = "";
            bc_bancoRnc = "";


        }


        public bool validar()
        {
            bool lret = true;

            if (lret && bc_bancoNombre.Equals(""))
            {
                errormsg = "Nombre de Banco no puede estar vacío.";
                lret = false;
            }
            return lret;
        }


        public int crearDatos()
        {
            bc_bancoid = 0;

            if (datamanager.ConexionAbrir())
            {

                // Preparamos consulta pra la actualización
                OracleCommand cmd = new OracleCommand("Insert into bc_bancos(Bancoid,Codigo,Nombre,Direccion,Rnc)" +
                                                " output INSERTED.bancoid" +
                                                " Values(@bancoid,@codigo,@Nombre,@Direccion,@Rnc)", datamanager.ConexionSQL);


                // Ponemos valores a los Parametros incluidos en la consulta de Creacion
                cmd.Parameters.AddWithValue("@bancoid", bc_bancoid);
                cmd.Parameters.AddWithValue("@Codigo", bc_bancoCodigo);
                cmd.Parameters.AddWithValue("@Nombre", bc_bancoNombre);
                cmd.Parameters.AddWithValue("@Direccion", bc_bancoDireccion);
                cmd.Parameters.AddWithValue("@Rnc", bc_bancoRnc);


                // y Retornamos el idbanco Insertado.
                bc_bancoid = (int)cmd.ExecuteScalar();

                // Cerramos conexión.
                datamanager.ConexionCerrar();

            }
            // si no logra insertar nada el idbanco Retornado es Cero
            return bc_bancoid;
        }


        public bool leerDatos(OracleDataReader dr, bool asignar)
        {

            bool encontrado = false;
            if (dr.Read())
            {
                encontrado = true;
                if (asignar)
                {
                    bc_bancoid = (int)dr["bancoid"];
                    bc_bancoCodigo = dr["Codigo"].ToString();
                    bc_bancoNombre = dr["Nombre"].ToString();
                    bc_bancoDireccion = dr["Direccion"].ToString();
                    bc_bancoRnc = dr["Rnc"].ToString();

                }
            }
            else
            {
                if (asignar) limpiar();
            }

            return encontrado;
        }

        public bool buscar(String pNombre, bool asignar)
        {
            var dr = datamanager.ConsultaLeer("select bancoid, Codigo,Nombre,Direccion,Rnc" +
                                               " from bc_bancos" +
                                               " where Nombre = '" + pNombre + "'");
            return leerDatos(dr, asignar);

        }

        public bool buscar(int Bancoid, bool asignar)
        {
            var dr = datamanager.ConsultaLeer("select bancoid,Codigo, nombre,Direccion,Rnc" +
                                               " from bc_bancos" +
                                               " where bancoid = " + Bancoid.ToString());


            return leerDatos(dr, asignar);
        }

        public bool buscarUltimo()
        {
            var dr = datamanager.ConsultaLeer(" Select  bancoid,Codigo, Nombre,Direccion,Rnc" +
                                              " From bc_bancos" +
                                              " Order by bancoid desc ");
            return leerDatos(dr, true);

        }

        public bool actualizarDatos()
        {
            int lRet = 0;

            if (datamanager.ConexionAbrir())
            {

                // Preparamos consulta pra la actualización
                OracleCommand cmd = new OracleCommand(" Update bc_bancos" +
                                                      " Set Codigo = @Codigo," +
                                                      " Nombre = @Nombre," +
                                                      " Direccion = @Direccion, " +
                                                      " Rnc = @Rnc " +
                                                      " Where Bancoid = @Bancoid ", datamanager.ConexionSQL);
 
                // Ponemos valores a los Parametros incluidos en la consulta de actualización
                cmd.Parameters.AddWithValue("@bancoid", bc_bancoid);
                cmd.Parameters.AddWithValue("@Nombre", bc_bancoNombre);
                cmd.Parameters.AddWithValue("@Direccion", bc_bancoDireccion);
                cmd.Parameters.AddWithValue("@Rnc", bc_bancoRnc);


                // Ejecutamos consulta de Actualización
                lRet = cmd.ExecuteNonQuery();

                // Cerramos conexión.
                datamanager.ConexionCerrar();

            }
            return lRet > 0;
        }

        public bool borrarDatos(int pbancoid)
        {
            bool lret = datamanager.ConsultaNodata("delete " +
                                               " from bc_bancos" +
                                               " where bancoid = " + pbancoid.ToString());
            if (lret) limpiar();
            return lret;
        }

    }
}
#endregion
