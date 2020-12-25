using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Capa_de_Datos
{
    public class Consulta
    {
        private Conexion conexion = new Conexion();

        SqlCommand comando = new SqlCommand();
        DataTable tabla = new DataTable();
        SqlDataReader leer;

        public DataTable Mostrar()
        {
            comando.Connection = conexion.abirConexion();
            comando.CommandText = "Select *from usu";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.Cerrarconexioin();

            return tabla;
        }

        public void Insertar_Datos(string pUsuario, string pContrasena, string pEmail)
        {
            comando.Connection = conexion.abirConexion();
            comando.CommandText = "Insert Into usu values ('"+pUsuario+"', PwdEncrypt('"+pContrasena+"'), '"+pEmail+"')";
            comando.ExecuteNonQuery();

        }


    }
}
