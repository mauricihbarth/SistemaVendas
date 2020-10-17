using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace SistemaVendas.Utils
{
    public class DAL
    {

        public static string Server = "localhost";
        public static string Database = "sistema_venda";
        public static string User = "root";
        public static string Password = "root";
        public static string ConnectionString = $"Server={Server};Database={Database};Uid={User};Pwd={Password}; SslMode=none; Charset=utf8;";
        private MySqlConnection Connection;

        public DAL()
        {
            Connection = new MySqlConnection(ConnectionString);
            Connection.Open();
        }


        public DataTable RetDataTable(string sql)
        {

            DataTable data = new DataTable();
            MySqlCommand Command = new MySqlCommand(sql, Connection);
            MySqlDataAdapter da = new MySqlDataAdapter(Command);
            da.Fill(data);

            return data;

        }

        //Execute insert , delete or update
        public void ExecutarComandoSQL(string sql)
        {
            MySqlCommand Command = new MySqlCommand(sql, Connection);
            Command.ExecuteNonQuery();
        }

    }
}
