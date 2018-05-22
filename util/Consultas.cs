using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionOO.util
{
    public class Consultas
    {
        #region [STRINGBUILDER CLIENTE]
        protected StringBuilder UltimoCliente = new StringBuilder()
                                               .Append("Select BC_CLIENTES.id_cliente," )
                                               .Append(" BC_TIPO_DOC_BANCARIOS.id_tipo_doc_bancario," )
                                               .Append(" BC_TIPO_DOC_BANCARIOS.NOMBRE AS TIPO_DOCUMENTOS," )
                                               .Append(" BC_CLIENTES.Num_documento,")
                                               .Append (" BC_CLIENTES.Nombre,")
                                               .Append(" BC_CLIENTES.Estado ")
                                               .Append(" FROM (BC_CLIENTES  INNER JOIN BC_TIPO_DOC_BANCARIOS ")
                                               .Append(" ON BC_CLIENTES.ID_TIPO_DOC_BANCARIO = BC_TIPO_DOC_BANCARIOS.ID_TIPO_DOC_BANCARIO)")
                                               .Append(" Order by id_cliente desc");

        protected StringBuilder LlenarCB_Clientes = new StringBuilder()
                                               .Append("SELECT ID_TIPO_DOC_BANCARIO, ")
                                               .Append("NOMBRE FROM BC_tipo_doc_bancarios");

        protected StringBuilder CrearDatos_CLientes = new StringBuilder()
                                               .Append("Insert into bc_clientes" )
                                               .Append("(id_cliente,id_tipo_doc_bancario,num_Documento ,nombre,estado)")
                                               .Append("Values(:id_cliente,:id_tipo_doc_bancario,:num_documento,:nombre,:estado)");

        protected StringBuilder ActualizaCliente = new StringBuilder()
                                               .Append("Update BC_CLIENTES SET ")
                                               .Append("id_tipo_doc_bancario = :id_tipo_doc_bancario,")
                                               .Append("Num_documento = :Num_documento,")
                                               .Append("Nombre = :Nombre, Estado = :Estado")
                                               .Append ("Where id_cliente = :id_cliente ");
        #endregion [FIN STRINGBUILDER CLIENTE]

        #region  [STRINGBUILDER BC_BANCOS]

        protected StringBuilder CrearDatos_BC_Banco = new StringBuilder()
                                               .Append("Insert into bc_bancos")
                                               .Append("(id_banco,Codigo,Nombre,Direccion,Rnc)")
                                               .Append("Values(:id_banco,:Codigo,:Nombre,:Direccion,:Rnc)");


        protected StringBuilder UltimoBanco = new StringBuilder().Append("Select id_banco,Codigo,Nombre,Direccion,Rnc From")
                                                                 .Append(" bc_bancos Order by id_banco desc");

        #endregion [FIN STRINGBUILDER BC_BANCOS]



        #region SUCURSALES 

        protected StringBuilder LlenarCB_SucursalBANCO= new StringBuilder()
                                              .Append("SELECT id_banco, ")
                                              .Append("NOMBRE FROM BC_Bancos ");
        #endregion


    }
}
