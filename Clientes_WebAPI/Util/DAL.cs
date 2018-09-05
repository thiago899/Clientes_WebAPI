using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Clientes_WebAPI.Util
{
    public class DAL
    {
        private static string Server = "DESKTOP-EOAELKP";
        private static string Database = "dbcliente";
        private static string User = "sa";
        private static string Password = "Thiago89";
        private SqlConnection connection;


        private string connectionString = $"Server={Server};Database={Database};User Id={User};Password={Password}";


        public DAL()
        {
            connection = new SqlConnection (connectionString);
            connection.Open();
        }

        //Executa: INSERT, UPDATE, DELETE
        public void ExecuteCommandSQL(string sql)
        {
            SqlCommand Command = new SqlCommand(sql, connection);
            Command.ExecuteNonQuery();
        }

        //Retorna dados do Banco

        public DataTable ReturnDataTable(string sql)
        {
            SqlCommand Command = new SqlCommand(sql, connection);
            SqlDataAdapter DataAdapter = new SqlDataAdapter(Command);
            DataTable Dados = new DataTable();
            DataAdapter.Fill(Dados);
            return Dados;
        }


    }
}
