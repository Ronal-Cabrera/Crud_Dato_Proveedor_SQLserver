using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace proyecto_final
{
    public class GuardarDataProveedor
    {
        string queryProveedor = "";
        ConectarBD conexion1 = new ConectarBD();

        public bool GuardarDataProveedor1(string Codigo2, string Nombre2, string Apellido2, string Direccion2, string Nit2, string Correo2,
                    string Telefono2, string Fecha2)
        {
            bool resultado2 = false;
            
            conexion1.inicioConec();
            try
            {
                queryProveedor = "insert into DatosProveedor values('" + Codigo2 + "', '" + Nombre2 + "', '" + Apellido2 + "', '" + Direccion2 + "'," +
                                " '" + Nit2 + "', '" + Correo2 + "', '" + Telefono2 + "', '" + Fecha2 + "')";
                SqlCommand cmd2 = new SqlCommand(queryProveedor, conexion1.conectar);
                cmd2.ExecuteNonQuery();
                resultado2 = true;
                conexion1.inicioDeconec();
            }
            catch (Exception)
            {
                resultado2 = false;
            }
            return resultado2;
        }

        public string ValidarNomProveedor(string ValidarNombre)
        {
            string resNomProv = "";

            conexion1.inicioConec();
            queryProveedor = "Select * from DatosProveedor where Nombre = '" + ValidarNombre + "'";

            SqlCommand cmdNomProv = new SqlCommand(queryProveedor, conexion1.conectar);
            SqlDataReader rsNomProv = cmdNomProv.ExecuteReader();
            if (rsNomProv.HasRows == false)
            {
                resNomProv = "error";
            }
            else
            {
                rsNomProv.Read();
                resNomProv = rsNomProv["Codigo"].ToString();
            }
            conexion1.inicioDeconec();

            return resNomProv;
        }

        public bool ValidandoCodigo(string CodigoAle)
        {
            bool CodigoValido = false;
            conexion1.inicioConec();
            queryProveedor = "Select * from DatosProveedor where Codigo = '" + CodigoAle + "'";
            SqlCommand cmdCod = new SqlCommand(queryProveedor, conexion1.conectar);
            SqlDataReader rsCod = cmdCod.ExecuteReader();
            if (rsCod.HasRows == false)
            {
                CodigoValido = false;
            }
            else
            {
                CodigoValido = true;
            }
            conexion1.inicioDeconec();

            return CodigoValido;
        }
    }
}