using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramacionOO.clases
{
    class bc_tipo_doc_bancarios : bc_cuentas
    {
        #region ATRIBUTOS
        public string codigoTipoDoc { get; set; }
        public char origen { get; set; }
        public string nombre { get; set; }
        #endregion

        #region CONSTRUCTORES
        public bc_tipo_doc_bancarios()
        {
        }

        public bc_tipo_doc_bancarios(string codigoTipoDoc, string nombre ,char origen)
        {
            this.codigoTipoDoc = codigoTipoDoc;
            this.nombre = nombre;
            this.origen = origen;
        }

        #endregion

        #region METODOS Y FUNCIONES
        public override void Limpiar()
        {
            codigoTipoDoc = "";
            nombre = "";
            origen = ' ';
            
        }

        public override bool Validar()
        {
            bool lret = true;

            if (lret && codigoTipoDoc.Equals(""))
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

                    codigoTipoDoc = dr["codigo"].ToString();
                    nombre = dr["nombre"].ToString();
                    origen = Convert.ToChar(dr["origen"]);
                }
            }
            else
            {
                if (asignar) Limpiar();
            }

            return encontrado;
        }

        public override bool Buscar(String pnombre, bool asignar)
        {
            var dr = datamanager.ConsultaLeer("select id_cuenta, codigo, origen where nombre = '" + pnombre + "'");
            return LeerDatos(dr, asignar);

        }      

        public override bool BuscarUltimo()

        {
            var dr = datamanager.ConsultaLeer("select codigo , nombre , origen From Bc_tipo_doc_bancarios Order by ID_TIPO_DOC_BANCARIO  desc");
            

            return LeerDatos(dr, true); 
        }

        public override int CrearDatos()
        {
            int filasAfectadas = 0;


            if (datamanager.ConexionAbrir())
            {


                var cmd = new OracleCommand("Insert into Bc_tipo_doc_bancarios(codigo,nombre,origen)" +
                                                        "Values(:codigo,:nombre,'"+origen+"')", datamanager.ConexionSQL);

                cmd.Parameters.AddWithValue("codigo", codigoTipoDoc);
                cmd.Parameters.AddWithValue("nombre", nombre);


                datamanager.ConexionAbrir();

                try
                {
                    filasAfectadas = cmd.ExecuteNonQuery();
                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString() + " \n\n DESCRIPCION DEL ERROR: ESTE CODIGO YA EXISTE ");
                }
                datamanager.ConexionCerrar();

            }
            return filasAfectadas;

        }

        public override bool BorrarDatos(int codigoTipoDoc)
        {
            throw new NotImplementedException();
        }

        public override bool BorrarDatos(string CodigoTipo)//Sobrecarga  del metodo BorrarDatos
        {
            bool lret = datamanager.ConsultaNodata("delete " +
                                               " from Bc_tipo_doc_bancarios" +
                                               " where codigo = '" + codigoTipoDoc.ToString() + "'");
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
                OracleCommand cmd = new OracleCommand(" Update Bc_tipo_doc_bancarios" +
                                                      " Set Origen = '" + origen + "'," +
                                                      " Nombre = :Nombre" +
                                                      " Where Codigo= :Codigo", datamanager.ConexionSQL);


                cmd.Parameters.AddWithValue("Codigo", codigoTipoDoc);
                cmd.Parameters.AddWithValue("nombre", nombre);
                datamanager.ConexionAbrir();
                cmd.ExecuteNonQuery();
                datamanager.ConexionCerrar();

                lRet = 1;
            }
            return lRet > 0;
        }

        public override bool BuscarCodigo(String Codigo)
        {
            var dr = datamanager.ConsultaLeer("select codigo from Bc_tipo_doc_bancarios where codigo = '"+Codigo.ToString()+"'");

            return LeerDatos(dr, false);
        }
        #endregion
    }
}
