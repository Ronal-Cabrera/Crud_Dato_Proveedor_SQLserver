using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace proyecto_final
{
    public class ConectarBD
    {
        string servidor = "DESKTOP-93N39NS\\SQLEXPRESS";
        string baseDatos = "UsuarioLogin";
        string usuario = "UsuarioUnico";
        string contra = "33022802";
        //Variables
        string conexion = "";
        string query = "";
       
        public SqlConnection conectar = new SqlConnection();

        public ConectarBD()
        {
            conexion = "Data source = " + servidor + "; Initial Catalog = " + baseDatos + "; user id = "
                + usuario + "; password = " + contra + ";";
            conectar.ConnectionString = conexion;
        }
        public void inicioConec()
        {
            try
            {
                conectar.Open();
                Console.WriteLine("Conectado");
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }
        public void inicioDeconec()
        {
            try
            {
                conectar.Close();
                Console.WriteLine("Desonectado");
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }

        public bool ValidarUsuario(string usuario, string contra)
        {
            bool resultado = false;
            query = "Select * from ULogin where usuario = '" + usuario + "' and contra = '" + contra + "'";
            SqlCommand cmd = new SqlCommand(query, conectar);
            SqlDataReader rs = cmd.ExecuteReader();

            if (rs.HasRows == false)
            {
                resultado = false;
            }
            else
            {
                //rs.Read();
                resultado = true;
            }
            return resultado;
        }

    }
}

