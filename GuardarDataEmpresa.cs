using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace proyecto_final
{
    public class GuardarDataEmpresa
    {
        ConectarBD conexion2 = new ConectarBD();
        string queryEmpresa = "";
        public bool GuardarDataProvEmpresa(string Codigo1, string Nombre1, string Direccion1, string Correo1, string Nit1, string Categoria1,
                    string Telefono1, string Fecha1)
        {
            bool resultado3 = false;
            conexion2.inicioConec();
            try
            {
                queryEmpresa = "insert into DatosEmpresaProveedora values('" + Codigo1 + "', '" + Nombre1 + "', '" + Direccion1 + "', '" + Correo1 + "', '" + Nit1 + "', '" + Categoria1 + "', '" + Telefono1 + "', '" + Fecha1 + "')";
                SqlCommand cmd3 = new SqlCommand(queryEmpresa, conexion2.conectar);
                cmd3.ExecuteNonQuery();
                resultado3 = true;
                conexion2.inicioDeconec();
            }
            catch (Exception)
            {
                resultado3 = false;
            }
            return resultado3;
        }

        public string ValidarNomEmpresaPP(string ValidarNombre)
        {
            string resNomEmpresa = "";
         
            conexion2.inicioConec();
            queryEmpresa = "Select * from DatosEmpresaProveedora where Nombre = '" + ValidarNombre + "'";

            SqlCommand cmdNomEmpre = new SqlCommand(queryEmpresa, conexion2.conectar);
            SqlDataReader rsNomEmpre = cmdNomEmpre.ExecuteReader();
            if (rsNomEmpre.HasRows == false)
            {
                resNomEmpresa = "error";
            }
            else
            {
                rsNomEmpre.Read();
                resNomEmpresa = rsNomEmpre["Codigo"].ToString();
            }
            conexion2.inicioDeconec();
            return resNomEmpresa;
        }

        public bool ValidandoSigCodigo(string CodigoAle)
        {
            bool CodigoValidoSig = false;
            conexion2.inicioConec();
            queryEmpresa = "Select * from DatosEmpresaProveedora where Codigo = '" + CodigoAle + "'";
            SqlCommand cmdCodSig = new SqlCommand(queryEmpresa, conexion2.conectar);
            SqlDataReader rsCodSig = cmdCodSig.ExecuteReader();
            if (rsCodSig.HasRows == false)
            {
                CodigoValidoSig = false;
            }
            else
            {
                CodigoValidoSig = true;
            }
            conexion2.inicioDeconec();

            return CodigoValidoSig;
        }
    }
}
