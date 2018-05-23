using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProgramacionOO.clases
{
    public  class bc_bancos :util.Consultas, IMantenimientos
    {
        #region Atributos
        public int bc_bancoid { get; set; }
       
        public string bc_bancoCodigo { get; set; }
        [StringLength(20, MinimumLength = 3, ErrorMessage = "El nombre debe de tener de 3 a 50 caracteres")]
        public string bc_bancoNombre { get; set; }
        [StringLength(50, MinimumLength = 3, ErrorMessage = "La Direccion  debe de tener de 3 a 30 caracteres")]
        public string bc_bancoDireccion { get; set; }
        public string bc_bancoRnc { get; set; }
        public string errormsg = "";

        #endregion

        #region Constructores

        public bc_bancos()
        {
            Limpiar();
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

        public virtual void Limpiar()
        {
            bc_bancoid = 0;
            bc_bancoNombre = "";
            bc_bancoCodigo = "";
            bc_bancoDireccion = "";
            bc_bancoRnc = "";

        }
        public virtual bool Validar()
        {
            bool lret = true;

            if (lret && bc_bancoNombre.Equals(""))
            {
                errormsg = "Nombre de Banco no puede estar vacío.";
                lret = false;
            }
            return lret;
        }

      
        public virtual int CrearDatos()
        {
            bc_bancoid = 0;

            if (datamanager.ConexionAbrir())
            {

               var cmd = new OracleCommand(CrearDatos_BC_Banco.ToString(), datamanager.ConexionSQL);

                cmd.Parameters.AddWithValue("id_banco", bc_bancoid);
                cmd.Parameters.AddWithValue("Codigo", bc_bancoCodigo);
                cmd.Parameters.AddWithValue("Nombre", bc_bancoNombre);
                cmd.Parameters.AddWithValue("Direccion", bc_bancoDireccion);
                cmd.Parameters.AddWithValue("Rnc", bc_bancoRnc);
                datamanager.ConexionAbrir();
                bc_bancoid = (int)cmd.ExecuteNonQuery();

                datamanager.ConexionCerrar();

            }
            return bc_bancoid;
        }
        public virtual bool LeerDatos(OracleDataReader dr, bool asignar)
        {
            bool encontrado = false;
            if (dr.Read())
            {
                encontrado = true;
                if (asignar)
                {
                    bc_bancoid = Convert.ToInt16(dr["id_banco"]);
                    bc_bancoCodigo = dr["Codigo"].ToString();
                    bc_bancoNombre = dr["Nombre"].ToString();
                    bc_bancoDireccion = dr["Direccion"].ToString();
                    bc_bancoRnc = dr["Rnc"].ToString();
                }
            }
            else
            {
                if (asignar) Limpiar();
            }

            return encontrado;
        }
        public virtual bool BuscarUltimo()
        {
            var dr = datamanager.ConsultaLeer(UltimoBanco.ToString());
            return LeerDatos(dr, true);
        }
        public virtual bool ActualizarDatos()
        {
            int lRet = 0;

            if (datamanager.ConexionAbrir())
            {
                var cmd = new OracleCommand(" Update bc_bancos" +
                                                     " Set id_banco = :id_banco," +
                                                      " Codigo = :Codigo," +
                                                      " Nombre = :Nombre," +
                                                      " Direccion = :Direccion, " +
                                                      " Rnc = :Rnc " +
                                                      " Where id_banco = :id_banco ", datamanager.ConexionSQL);

                cmd.Parameters.AddWithValue("id_banco", bc_bancoid);
                cmd.Parameters.AddWithValue("Codigo", bc_bancoCodigo);
                cmd.Parameters.AddWithValue("Nombre", bc_bancoNombre);
                cmd.Parameters.AddWithValue("Direccion", bc_bancoDireccion);
                cmd.Parameters.AddWithValue("Rnc", bc_bancoRnc);
                datamanager.ConexionAbrir();
                cmd.ExecuteNonQuery();
                datamanager.ConexionCerrar();
            }
            return lRet > 0;
        }
        public virtual bool BorrarDatos(int pbancoid)
        {
            bool lret = datamanager.ConsultaNodata("delete " +
                                               " from bc_bancos" +
                                               " where id_banco = " + pbancoid.ToString());
            if (lret) Limpiar();
            return lret;
        }
        public virtual bool Buscar(String pNombre, bool asignar)
        {
            throw new NotImplementedException();

        }
        public virtual bool Buscar(int Bancoid, bool asignar)
        {
            throw new NotImplementedException();
        }
    }
}
#endregion
