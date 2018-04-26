using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionOO.clases
{
    class bc_clientes : Mantenimientos
    {



        private int bc_Clienteid { get; set; }
        private string bc_TipoDocumento { get; set; }
        private string bc_NumeroDocumento { get; set; }
        private string bc_Nombre { get; set; }
        private string bc_estado { get; set; }
        private int bc_numeroControlRecurrencia { get; set; }
      //  private string Errormsg = "";


        public bc_clientes(int pbc_Clienteid,
            string pbc_TipoDocumento,
            string pbc_NumeroDocumento,
            string pbc_Nombre,
            string pbc_estado,
            int pbc_numeroControlRecurrencia
            )
        {
            this.bc_Clienteid = pbc_Clienteid;
            this.bc_TipoDocumento = pbc_TipoDocumento;
            this.bc_NumeroDocumento = pbc_NumeroDocumento;
            this.bc_Nombre = pbc_Nombre;
            this.bc_estado = pbc_estado;
            this.bc_numeroControlRecurrencia = pbc_numeroControlRecurrencia;
        }

        public void Limpiar()
        {
            bc_Clienteid = 0;
            bc_TipoDocumento = "";
            bc_NumeroDocumento = "";
            bc_Nombre = "";
            bc_estado = "";
            bc_numeroControlRecurrencia = 0;


        }

        public bool Validar()
        {
            bool lret = true;

            if (lret && bc_Nombre.Equals(""))
            {
             //   Errormsg = "Nombre de Banco no puede estar vacío.";
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
                    bc_Clienteid = Convert.ToInt16(dr["clienteid"]);
                    bc_TipoDocumento = dr["tipo_documento"].ToString();
                    bc_NumeroDocumento = dr["numero_documento"].ToString();
                    bc_Nombre = dr["nombre"].ToString();
                    bc_estado = dr["estado"].ToString();
                    bc_numeroControlRecurrencia =Convert.ToInt16( dr["numcontrol_concurrencia"]);

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

            bc_Clienteid = 0;

            if (datamanager.ConexionAbrir())
            {



                OracleCommand cmd = new OracleCommand("Insert into bc_clientes(clienteid,tipo_documento,numero_documento,nombre,estado,numcontrol_concurrencia)" +
                                                        " Values(:clienteid,:tipo_documento,:numero_documento,:nombre,:estado, : numcontrol_concurrencia)", datamanager.ConexionSQL);

                cmd.Parameters.AddWithValue("clienteid", bc_Clienteid);
                cmd.Parameters.AddWithValue("tipo_documento", bc_TipoDocumento);
                cmd.Parameters.AddWithValue("numero_documento", bc_NumeroDocumento);
                cmd.Parameters.AddWithValue("nombre", bc_Nombre);
                cmd.Parameters.AddWithValue("estado", bc_estado);
                cmd.Parameters.AddWithValue("numcontrol_concurrencia", bc_numeroControlRecurrencia);

                datamanager.ConexionAbrir();
                bc_Clienteid = (int)cmd.ExecuteNonQuery();

                datamanager.ConexionCerrar();

            }
            return bc_Clienteid;

        }

        public bool ActualizarDatos()
        {
            throw new NotImplementedException();
        }

        public bool borrarDatos(int pbancoid)
        {
            throw new NotImplementedException();
        }

        public bool buscarUltimo()
        {
            throw new NotImplementedException();
        }

        public bool BuscarUltimo()
        {
            throw new NotImplementedException();
        }

        public bool BorrarDatos(int pbancoid)
        {
            throw new NotImplementedException();
        }

        public bool Buscar(string pNombre, bool asignar)
        {
            throw new NotImplementedException();
        }

        public bool Buscar(int Bancoid, bool asignar)
        {
            throw new NotImplementedException();
        }
    }
}
