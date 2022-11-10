using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace proyecto_final
{
    public class GuardarDataProductos
    {
        ConectarBD conexion3 = new ConectarBD();

        public bool GuardarDataProducto(string Tipo3, string Area3, string Cantidad3, string Codigo3, string Costo3, string Fecha3,
        string Marca3, string Nombre3, string Presentacion3, string Id3, string Ubicacion3)
        {

            bool resultado1 = false;

            try
            {
                conexion3.inicioConec();
                string queryProducto = "insert into DatosProducto values('" + Codigo3 + "', '" + Nombre3 + "', '" + Cantidad3 + "', '" + Marca3 + "'" +
                                ", '" + Presentacion3 + "', '" + Fecha3 + "', '" + Ubicacion3 + "', '" + Costo3 + "', '" + Id3 + "', '" + Tipo3 + "', '" + Area3 + "')";
                SqlCommand cmd1 = new SqlCommand(queryProducto, conexion3.conectar);
                cmd1.ExecuteNonQuery();
                resultado1 = true;
                conexion3.inicioDeconec();
            }
            catch (Exception)
            {
                resultado1 = false;
            }

            return resultado1;
        }
    }
}
