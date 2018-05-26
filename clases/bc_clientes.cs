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
    class bc_clientes : bc_cuentas
    {
        #region ATRIBUTOS
        public int bc_Clienteid { get; set; }
        public string bc_TipoDocumento { get; set; }
        public string bc_NumeroDocumento { get; set; }
        public string bc_Nombre { get; set; }
        public string bc_Estado { get; set; }
        public int bc_numeroControlRecurrencia { get; set; }
        #endregion

        #region CONSTRUCTORES

        public bc_clientes(
            int pbc_Clienteid,
            string pbc_TipoDocumento,
            string pbc_NumeroDocumento,
            string pbc_Nombre,
            string pbc_Estado,
            int pbc_numeroControlRecurrencia
            )

        {
            this.bc_Clienteid = pbc_Clienteid;
            this.bc_TipoDocumento = pbc_TipoDocumento;
            this.bc_NumeroDocumento = pbc_NumeroDocumento;
            this.bc_Nombre = pbc_Nombre;
            this.bc_Estado = pbc_Estado;
            this.bc_numeroControlRecurrencia = pbc_numeroControlRecurrencia;
        }

        public bc_clientes()
        {
            Limpiar();
        }

        #endregion

        #region METODOS Y FUNCIONES 

        public override void Limpiar()
        {
            bc_Clienteid = 0;
            bc_TipoDocumento = "";
            bc_NumeroDocumento = "";
            bc_Nombre = "";
            bc_Estado = "";
            bc_numeroControlRecurrencia = 0;
        }

        public override bool Validar()
        {
            bool lret = true;

            if (lret && bc_Nombre.Equals(""))
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
                   // bc_Clienteid = Convert.ToInt32(dr["id_cliente"]);
                    bc_TipoDocumento = dr["TIPO_DOCUMENTOS"].ToString();
                    bc_NumeroDocumento = dr["num_documento"].ToString();
                    bc_Nombre = dr["nombre"].ToString();
                    bc_Estado = dr["estado"].ToString();

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

            bc_Clienteid = 0;

            if (datamanager.ConexionAbrir())
            {

                var cmd = new OracleCommand(CrearDatos_CLientes.ToString(), datamanager.ConexionSQL);

                cmd.Parameters.AddWithValue("id_tipo_doc_bancario", bc_TipoDocumento);
                cmd.Parameters.AddWithValue("num_Documento", bc_NumeroDocumento);
                cmd.Parameters.AddWithValue("nombre", bc_Nombre);
                cmd.Parameters.AddWithValue("estado", bc_Estado);

                datamanager.ConexionAbrir();
                bc_Clienteid = (int)cmd.ExecuteNonQuery();

                datamanager.ConexionCerrar();

            }
            return bc_Clienteid;

        }

        public override bool ActualizarDatos()
        {
            int lRet = 0;

            if (datamanager.ConexionAbrir())
            {
                var cmd = new OracleCommand(ActualizaCliente.ToString(), datamanager.ConexionSQL);

                cmd.Parameters.AddWithValue("id_cliente", bc_Clienteid);
                cmd.Parameters.AddWithValue("id_tipo_doc_bancario", bc_TipoDocumento);
                cmd.Parameters.AddWithValue("Num_documento", bc_NumeroDocumento);
                cmd.Parameters.AddWithValue("Nombre", bc_Nombre);
                cmd.Parameters.AddWithValue("Estado", bc_Estado);
                datamanager.ConexionAbrir();
                cmd.ExecuteNonQuery();
                datamanager.ConexionCerrar();
            }
            return lRet > 0;
        }

        public override bool BuscarUltimo()
        {
            var dr = datamanager.ConsultaLeer(UltimoCliente.ToString());

            return LeerDatos(dr, true);
        }

        public virtual void SelectComboBox(ComboBox cb)
        {
            var dr = datamanager.ConsultaLeer(LlenarCB_Clientes.ToString());

            while (dr.Read())
            {
                cb.Items.Add(dr[0].ToString() + " - " + dr[1].ToString());
            }
        }

        public virtual DataTable BuscarClientes(string campo, string palabras)
        {
            var cm = new OracleCommand();

            if (datamanager.ConexionAbrir())

            {
                try
                {
                    cm = datamanager.ConexionSQL.CreateCommand();
                    cm.CommandType = CommandType.Text;
                    cm.CommandText = "select * from Bc_clientes where " + campo + " like '" + palabras + "%'";
                    cm.ExecuteNonQuery();
                    datamanager.ConexionCerrar();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error: Exprexion SQL no completada");
                }

            }
            return LlenarDataGridView(cm);
        }

       public override DataTable verTodos()
        {
            var cm = new OracleCommand();

            if (datamanager.ConexionAbrir())


            {

                cm = datamanager.ConexionSQL.CreateCommand();
                cm.CommandType = CommandType.Text;
                cm.CommandText = UltimoCliente.ToString();
                cm.ExecuteNonQuery();
                datamanager.ConexionCerrar();
            }


            return LlenarDataGridView(cm);

        }
    }
}
#endregion

