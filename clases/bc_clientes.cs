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
        public int bc_Clienteid { get; set; }
        public string bc_TipoDocumento { get; set; }
        public string bc_NumeroDocumento { get; set; }
        public string bc_Nombre { get; set; }
        public string bc_estado { get; set; }
        public int bc_numeroControlRecurrencia { get; set; }
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
        public bc_clientes()
        {
            Limpiar();
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
                    bc_Clienteid = Convert.ToInt16(dr["ID_CLIENTE"]);
                    bc_TipoDocumento = dr["tipo_documento"].ToString();
                    bc_NumeroDocumento = dr["num_documento"].ToString();
                    bc_Nombre = dr["nombre"].ToString();
                    bc_estado = dr["estado"].ToString();

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



                OracleCommand cmd = new OracleCommand("Insert into bc_clientes(clienteid,tipo_documento,num_Documento ,nombre,estado,numcontrol_concurrencia)" +
                                                        " Values(:clienteid,:tipo_documento,:num_documento,:nombre,:estado, : numcontrol_concurrencia)", datamanager.ConexionSQL);

                cmd.Parameters.AddWithValue("clienteid", bc_Clienteid);
                cmd.Parameters.AddWithValue("tipo_documento", bc_TipoDocumento);
                cmd.Parameters.AddWithValue("num_Documento", bc_NumeroDocumento);
                cmd.Parameters.AddWithValue("nombre", bc_Nombre);
                cmd.Parameters.AddWithValue("estado", bc_estado);

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
            var dr = datamanager.ConsultaLeer(" Select id_cliente,Tipo_documento,Num_documento, Nombre,Estado" +
                                             "  From BC_CLIENTES" +
                                             "  Order by id_cliente desc");
            return LeerDatos(dr, true);
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
