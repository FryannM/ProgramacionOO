using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramacionOO.clases
{
    class bc_sucursales : bc_clientes
    {
        #region ATRIBUTOS
        public int bc_id_Sucursal { get; set; }
        public int bc_id_Banco { get; set; }
        public string bc_Codigo { get; set; }

        public string bc_Direccion { get; set; }
        public string bc_Telefono { get; set; }
        public string bc_Correo { get; set; }
        public string bc_NombreBanco { get; set; }
        #endregion

        #region CONSTRUCTORES
        public bc_sucursales(int pbc_id_Sucursal, int
            pbc_id_Banco,
            string pbc_Codigo,
            string pbc_Nombre,
            string pbc_Direccion,
            string pbc_Telefono,
            string pbc_Correo,
            string pbc_nombreBanco
            )


        {
            this.bc_id_Sucursal = pbc_id_Sucursal;
            this.bc_id_Banco = pbc_id_Banco;
            this.bc_NombreBanco = pbc_nombreBanco;
            this.bc_Codigo = pbc_Codigo;
            this.bc_Nombre = pbc_Nombre;
            this.bc_Direccion = pbc_Direccion;
            this.bc_Telefono = pbc_Telefono;
            this.bc_Correo = pbc_Correo;
        }

        public bc_sucursales()
        {
            Limpiar();
        }

        #endregion

        #region METODOS Y FUNCIONES

        public override void Limpiar()
        {

            bc_id_Sucursal = 0;
            bc_id_Banco = 0;
            bc_Nombre = "";
            bc_Direccion = "";
            bc_Telefono = "";
            bc_Correo = "";
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
                    bc_id_Sucursal = Convert.ToInt16(dr["id_Sucursal"]);
                    bc_NombreBanco = (dr["Nombre_Banco"].ToString());
                    bc_id_Banco = Convert.ToInt16(dr["id_banco"].ToString());
                    bc_Codigo = dr["codigo"].ToString();
                    bc_Direccion = dr["direccion"].ToString();
                    bc_Nombre = dr["nombre"].ToString();
                    bc_Telefono = dr["telefono"].ToString();
                    bc_Correo = dr["correo"].ToString();

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

            bc_id_Sucursal = 0;

            if (datamanager.ConexionAbrir())
            {

                var cmd = new OracleCommand(CrearSucursal.ToString(), datamanager.ConexionSQL);

                cmd.Parameters.AddWithValue("id_banco", bc_id_Banco);
                cmd.Parameters.AddWithValue("codigo", bc_Codigo);
                cmd.Parameters.AddWithValue("nombre", bc_Nombre);
                cmd.Parameters.AddWithValue("direccion", bc_Direccion);
                cmd.Parameters.AddWithValue("Telefono", bc_Telefono);
                cmd.Parameters.AddWithValue("Correo", bc_Correo);

                datamanager.ConexionAbrir();
                bc_id_Banco = (int)cmd.ExecuteNonQuery();
                datamanager.ConexionCerrar();
            }
            return bc_id_Sucursal;
        }
        public override void SelectComboBox(ComboBox cb)
        {
            var dr = datamanager.ConsultaLeer(LlenarCB_SucursalBANCO.ToString());

            while (dr.Read())
            {
                cb.Items.Add(dr[0].ToString() + " - " + dr[1].ToString());
            }
        }
       public override bool BuscarUltimo()
        {
            var dr = datamanager.ConsultaLeer(BuscarUltimaSucursal.ToString());

            return LeerDatos(dr, true);
        }
        public override bool ActualizarDatos()
        {
            int lRet = 0;

            if (datamanager.ConexionAbrir())
            {

              
                var cmd = new OracleCommand(ActualizarSucursal.ToString(), datamanager.ConexionSQL);

                cmd.Parameters.AddWithValue("id_sucursal", bc_id_Sucursal);
                cmd.Parameters.AddWithValue("Id_Banco", bc_id_Banco);
                cmd.Parameters.AddWithValue("Codigo", bc_Codigo);
                cmd.Parameters.AddWithValue("Nombre", bc_Nombre);
                cmd.Parameters.AddWithValue("Direccion", bc_Direccion);
                cmd.Parameters.AddWithValue("Telefono", bc_Telefono);
                cmd.Parameters.AddWithValue("Correo", bc_Correo);
                datamanager.ConexionAbrir();
                cmd.ExecuteNonQuery();
                datamanager.ConexionCerrar();
            }
            return lRet > 0;

         
        }

    }
}
#endregion
