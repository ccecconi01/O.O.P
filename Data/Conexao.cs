using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0006.ProjetoLogin.Data
{
    class Conexao
    {
        SqlConnection conn = new SqlConnection(); // communication token attribute

        public Conexao()
        {
            // connection string            
            conn.ConnectionString = @"Data Source=DESKTOP-JPGJMN5\SQLEXPRESS ;Initial Catalog=poo24 ;Integrated Security=True";
        }

        public SqlConnection conectar ()
        {
            // database connecting
            if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();

            return conn;
        }

        public void desconectar()
        {
            // database disconecting
            if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }
    }
}
