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
        public string bc_Estado { get; set; }
        public int bc_numeroControlRecurrencia { get; set; }
      //  private string Errormsg = "";


        public bc_clientes(int pbc_Clienteid,
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
        public void Limpiar()
        {
            bc_Clienteid = 0;
            bc_TipoDocumento = "";
            bc_NumeroDocumento = "";
            bc_Nombre = "";
            bc_Estado = "";
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
                    bc_Estado = dr["estado"].ToString();

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



                OracleCommand cmd = new OracleCommand("Insert into bc_clientes(id_cliente,tipo_documento,num_Documento ,nombre,estado)" +
                                                        " Values(:id_cliente,:tipo_documento,:num_documento,:nombre,:estado)", datamanager.ConexionSQL);

                cmd.Parameters.AddWithValue("id_cliente", bc_Clienteid);
                cmd.Parameters.AddWithValue("tipo_documento", bc_TipoDocumento);
                cmd.Parameters.AddWithValue("num_Documento", bc_NumeroDocumento);
                cmd.Parameters.AddWithValue("nombre", bc_Nombre);
                cmd.Parameters.AddWithValue("estado", bc_Estado);

                datamanager.ConexionAbrir();
                bc_Clienteid = (int)cmd.ExecuteNonQuery();

                datamanager.ConexionCerrar();

            }
            return bc_Clienteid;

        }
        public bool ActualizarDatos()
        {
            int lRet = 0;
         
            if (datamanager.ConexionAbrir())
            {
                OracleCommand cmd = new OracleCommand(" Update bc_clientes" +
                                                     " Set id_cliente = :id_cliente," +
                                                      " Tipo_documento = :Tipo_documento," +
                                                      " Num_documento = :Num_documento," +
                                                      " Nombre = :Nombre, " +
                                                      " Estado = :Estado " +
                                                      " Where id_cliente = :id_cliente ", datamanager.ConexionSQL);

                cmd.Parameters.AddWithValue("id_cliente", bc_Clienteid);
                cmd.Parameters.AddWithValue("Tipo_documento", bc_TipoDocumento);
                cmd.Parameters.AddWithValue("Num_documento", bc_NumeroDocumento);
                cmd.Parameters.AddWithValue("Nombre", bc_Nombre);
                cmd.Parameters.AddWithValue("Estado", bc_Estado);
                datamanager.ConexionAbrir();
                cmd.ExecuteNonQuery();
                datamanager.ConexionCerrar();
            }
            return lRet > 0;
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
