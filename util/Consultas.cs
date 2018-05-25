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
                                               .Append("Select BC_CLIENTES.id_cliente,")
                                               .Append(" BC_TIPO_DOC_BANCARIOS.id_tipo_doc_bancario,")
                                               .Append(" BC_TIPO_DOC_BANCARIOS.NOMBRE AS TIPO_DOCUMENTOS,")
                                               .Append(" BC_CLIENTES.Num_documento,")
                                               .Append("BC_CLIENTES.Nombre,")
                                               .Append(" BC_CLIENTES.Estado ")
                                               .Append(" FROM (BC_CLIENTES  INNER JOIN BC_TIPO_DOC_BANCARIOS ")
                                               .Append(" ON BC_CLIENTES.ID_TIPO_DOC_BANCARIO = BC_TIPO_DOC_BANCARIOS.ID_TIPO_DOC_BANCARIO)")
                                               .Append(" Order by id_cliente desc");

        protected StringBuilder LlenarCB_Clientes = new StringBuilder()
                                               .Append("SELECT ID_TIPO_DOC_BANCARIO, ")
                                               .Append("NOMBRE FROM BC_tipo_doc_bancarios");

        protected StringBuilder CrearDatos_CLientes = new StringBuilder()
                                               .Append("Insert into bc_clientes")
                                               .Append("(id_cliente,id_tipo_doc_bancario,num_Documento ,nombre,estado)")
                                               .Append("Values(:id_cliente,:id_tipo_doc_bancario,:num_documento,:nombre,:estado)");

        protected StringBuilder ActualizaCliente = new StringBuilder()
                                               .Append("Update BC_CLIENTES SET ")
                                               .Append("id_tipo_doc_bancario = :id_tipo_doc_bancario,")
                                               .Append("Num_documento = :Num_documento,")
                                               .Append("Nombre = :Nombre, Estado = :Estado")
                                               .Append("Where id_cliente = :id_cliente ");
        #endregion [FIN STRINGBUILDER CLIENTE]

        #region  [STRINGBUILDER BC_BANCOS]

        protected StringBuilder CrearDatos_BC_Banco = new StringBuilder()
                                               .Append("Insert into bc_bancos")
                                               .Append("(id_banco,Codigo,Nombre,Direccion,Rnc)")
                                               .Append("Values(:id_banco,:Codigo,:Nombre,:Direccion,:Rnc)");


        protected StringBuilder UltimoBanco = new StringBuilder()
                                                .Append("Select id_banco,Codigo,Nombre,Direccion,Rnc From")
                                                .Append(" bc_bancos Order by id_banco desc");


        #endregion [FIN STRINGBUILDER BC_BANCOS]

        #region [STRINGBUILDER SUCURSALES] 

        protected StringBuilder LlenarCB_SucursalBANCO = new StringBuilder()
                                              .Append("SELECT id_banco, ")
                                              .Append("NOMBRE FROM BC_Bancos ");

        protected StringBuilder CrearSucursal = new StringBuilder()
            .Append("Insert into bc_sucursales(Id_Banco,Codigo,Nombre ,Direccion,Telefono,Correo)")
            .Append ( " Values(:Id_Banco,:Codigo,:Nombre,:Direccion,:Telefono,:Correo)");

        protected StringBuilder BuscarUltimaSucursal = new StringBuilder()
            .Append("Select bc_bancos.id_banco,bc_bancos.nombre as Nombre_Banco ,")
            .Append(" bc_sucursales.id_sucursal,  bc_sucursales.id_banco, bc_sucursales.codigo, ")
            .Append(" bc_sucursales.Nombre, bc_sucursales.direccion, ")
            .Append(" bc_sucursales.telefono, bc_sucursales.correo ")
            .Append(" From bc_sucursales inner join bc_bancos ")
            .Append(" on  bc_sucursales.id_banco = bc_bancos.id_banco ")
            .Append(" Order by id_sucursal desc ");

        protected StringBuilder ActualizarSucursal = new StringBuilder()
            .Append("Update bc_sucursales")
            .Append(" Set id_sucursal = :id_sucursal,")
            .Append(" Id_Banco = :Id_Banco, Codigo = :Codigo,")
            .Append(" Nombre = :Nombre, Direccion = :Direccion, ")
            .Append(" Telefono = :Telefono,  Correo = :Correo ")
            .Append(" Where id_sucursal = :id_sucursal ");




        #endregion



        #region [STRINGBUILDER TITULARES] 


        protected StringBuilder CrearTitular = new StringBuilder()
             .Append("Insert into bc_titulares_cuentas")
             .Append("id_titular_cuenta,id_cuenta,id_cliente")
              .Append(" Values(:id_titular_cuenta,:id_cuenta,:id_cliente");

        protected StringBuilder ActualizarTitular = new StringBuilder()
            .Append("Update bc_titulares_cuentas")
            .Append(" Set id_titular_cuenta = :id_titular_cuenta,")
            .Append(" id_cuenta = :id_cliente,")
            .Append(" id_cliente = :id_cliente,")
            .Append(" Where id_titular_cuenta = :id_cliente");

        protected StringBuilder BuscarUltimoTitular = new StringBuilder()
            .Append(" Select bc_titulares_cuentas.id_titular_cuenta,bc_cuentas.codigo,bc_clientes.NOMBRE,")
            .Append(" bc_titulares_cuentas.id_cuenta, bc_titulares_cuentas.id_cliente")
            .Append(" From bc_titulares_cuentas")
            .Append(" INNER JOIN bc_cuentas")
            .Append(" on bc_titulares_cuentas.ID_CUENTA = bc_cuentas.id_cuenta")
            .Append(" INNER JOIN bc_clientes")
            .Append(" on bc_titulares_cuentas.ID_CLIENTE = bc_clientes.ID_CLIENTE")
            .Append(" Order by id_titular_cuenta desc");

        #endregion

    }
}
