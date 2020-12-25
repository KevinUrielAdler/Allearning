using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Capa_de_Datos
{
    public class Conexion
    {
      
        private SqlConnection Conexionn = new SqlConnection("Data source=DESKTOP-DT9KHRE; Initial Catalog=regis; User Id=sa; Password=LAlajueleacaca");

        public SqlConnection abirConexion()
        {
            if(Conexionn.State == ConnectionState.Closed)          
                Conexionn.Open();
                return Conexionn;
            

        }
        public SqlConnection Cerrarconexioin()
        {
            if (Conexionn.State == ConnectionState.Open)      
                Conexionn.Close();
                return Conexionn;
            


        }

    }
}
