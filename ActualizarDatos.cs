using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace proyecto_final
{
    public class ActualizarDatos
    {
        string query = "";
        ConectarBD Mconect = new ConectarBD();
        bool validar1 = false;

        public bool EliminarEmpresa(string nombre)
        {
            try
            {
                Mconect.inicioConec();
                query = "DELETE FROM DatosEmpresaProveedora where Codigo = '" + nombre + "'";
                SqlCommand cmdNomEmpre = new SqlCommand(query, Mconect.conectar);
                cmdNomEmpre.ExecuteNonQuery();
                Mconect.inicioDeconec();
                validar1 = true;
            }
            catch (Exception)
            {
                validar1 = false;
            }
            return validar1;
        }
        public bool EliminarProveedor(string nombre)
        {
            try
            {
                Mconect.inicioConec();
                query = "DELETE FROM DatosProveedor where Codigo = '" + nombre + "'";
                SqlCommand cmdNomEmpre = new SqlCommand(query, Mconect.conectar);
                cmdNomEmpre.ExecuteNonQuery();
                Mconect.inicioDeconec();
                validar1 = true;
            }
            catch (Exception)
            {
                validar1 = false;
            }
            return validar1;
        }
        public bool EliminarProducto(string nombre)
        {
            try
            {
                Mconect.inicioConec();
                string queryEmpresa = "DELETE FROM DatosProducto where Codigo = '" + nombre + "'";
                SqlCommand cmdNomEmpre = new SqlCommand(queryEmpresa, Mconect.conectar);
                cmdNomEmpre.ExecuteNonQuery();
                Mconect.inicioDeconec();
                validar1 = true;
            }
            catch (Exception)
            {
                validar1 = false;
            }
            return validar1;
        }
    }
}
