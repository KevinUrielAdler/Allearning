using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Capa_de_Datos;

namespace Capa_Negocio
{
    public class validar
    {
        private Consulta objeto = new Consulta();
        private Conexion conexion = new Conexion();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarTabla()
        {
            DataTable tabla = new DataTable();
            tabla = objeto.Mostrar();

            return tabla;

        }


        public void InsertarParametros(string pUsuario, string pContrasena, string pEmail)
        {
            objeto.Insertar_Datos(pUsuario, pContrasena, pEmail);        
        }

        public int ValidarParametro(string pUsuario, string pContrasena)
        {
            int resultado = -1;

            comando.Connection = conexion.abirConexion();
            comando.CommandText = "Select * From usu Where Nombre = '" + pUsuario + "' and PwdCompare('" + pContrasena + "',Contraseña) = 1";
            SqlDataReader leer = comando.ExecuteReader();

            while (leer.Read())
            {
                resultado = 50;
            }

            conexion.Cerrarconexioin();
            return resultado;
        }
    }
}
