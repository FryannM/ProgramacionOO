using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionOO.clases
{
    class bc_doc_Bancarios : Mantenimientos
    {

     


        public int id_doc_Bancario { get; set; }
        public int id_Tipo_doc_Bancarios { get; set; }
        public int id_cuenta { get; set; }
        public int id_cliente { get; set; }
        public int id_Banco { get; set; }
        public double bc_importe { get; set; }
        public DateTime bc_Fecha { get; set; }




        public bc_doc_Bancarios(int pbc_id_doc_Bancario,
           int pbc_id_Tipo_doc_Bancarios, int pbc_id_cuenta,
           int pbc_id_cliente,
           int pbc_id_Banco,
           double pbc_importe,
           DateTime pbc_bc_Fecha
           )


        {
            this.id_doc_Bancario = pbc_id_doc_Bancario;
            this.id_Tipo_doc_Bancarios = pbc_id_Tipo_doc_Bancarios;
            this.id_cuenta = pbc_id_cuenta;
            this.bc_importe = pbc_importe;
            this.id_cliente = pbc_id_cliente;
            this.id_Banco = pbc_id_Banco;
            this.bc_Fecha = pbc_bc_Fecha;
        }
        public bc_doc_Bancarios()
        {
            Limpiar();
        }
        public void Limpiar()
        {
            id_doc_Bancario = 0;
            id_Tipo_doc_Bancarios = 0;
            id_cuenta = 0;
            bc_importe = 0;
            id_cliente = 0;
            id_Banco = 0;



        }

        public bool Validar()
        {
            bool lret = true;

            if (lret && id_Tipo_doc_Bancarios.Equals(""))
            {

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
                    id_doc_Bancario = Convert.ToInt16(dr["ID_DOC_BANCARIO"]);
                    id_Tipo_doc_Bancarios = Convert.ToInt16(dr["ID_TIPO_DOC_BANCARIO"]);
                    id_cuenta = Convert.ToInt16(dr["ID_CUENTA"]);
                    id_cliente = Convert.ToInt16(dr["ID_CLIENTE"]);
                    id_Banco = Convert.ToInt16(dr["ID_BANCO"]);
                    bc_importe = Convert.ToInt16(dr["IMPORTE"]);
                    bc_Fecha = Convert.ToDateTime(dr["FECHA"]);

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

            id_doc_Bancario = 0;

            if (datamanager.ConexionAbrir())
            {

                var cmd = new OracleCommand("Insert into BC_DOC_BANCARIOS" +
                                                      " ( ID_DOC_BANCARIO," +
                                                        " ID_TIPO_DOC_BANCARIO ," +
                                                        " ID_CUENTA,ID_BANCO," +
                                                        " IMPORTE ,FECHA)" +
                                                        " Values(:ID_DOC_BANCARIO," +
                                                        " :ID_TIPO_DOC_BANCARIO," +
                                                        " :ID_CUENTA," +
                                                        " :ID_BANCO,:IMPORTE,:FECHA)", datamanager.ConexionSQL);

                cmd.Parameters.AddWithValue("ID_DOC_BANCARIO", id_doc_Bancario);
                cmd.Parameters.AddWithValue("ID_TIPO_DOC_BANCARIO", id_Tipo_doc_Bancarios);
                cmd.Parameters.AddWithValue("ID_CUENTA", id_cuenta);
                cmd.Parameters.AddWithValue("ID_BANCO", id_Banco);
                cmd.Parameters.AddWithValue("IMPORTE", bc_importe);
                cmd.Parameters.AddWithValue("FECHA", bc_importe);


                datamanager.ConexionAbrir();
                id_doc_Bancario = (int)cmd.ExecuteNonQuery();

                datamanager.ConexionCerrar();

            }
            return id_doc_Bancario;

        }


        public bool BuscarUltimo()
        {
            var dr = datamanager.ConsultaLeer(" Select ID_DOC_BANCARIO,ID_TIPO_DOC_BANCARIO,ID_CUENTA, ID_BANCO,IMPORTE,FECHA" +
                                             "  From BC_DOC_BANCARIOS" +
                                             "  Order by ID_DOC_BANCARIO desc");
            return LeerDatos(dr, true);
        }



        public bool ActualizarDatos()
        {
            throw new NotImplementedException();
        }

        public bool BorrarDatos(int pbancoid)
        {
            throw new NotImplementedException();
        }

        public bool Buscar(string Param, bool asignar)
        {
            throw new NotImplementedException();
        }

        public bool Buscar(int Param, bool asignar)
        {
            throw new NotImplementedException();
        }
    }
}
