using MySql.Data.MySqlClient;
using System.Data;

namespace SistemaVendas.Uteis
{
    //Data Access Layer
    public class DAL
    {
        private static string Server = "localhost";
        private static string Database = "sistema_venda";
        private static string User = "developer";
        private static string Password = "1234567";
        private static string ConnectionString = $"Server={Server};Database={Database};Uid={User};Pwd={Password};Sslmode=none;Charset=utf8;";
        private static MySqlConnection Connection;

        public DAL()
        {
            Connection = new MySqlConnection(ConnectionString);
            Connection.Open();
        }

        //Espera um parâmetro do tipo string 
        //contendo um comando SQL do tipo SELECT
        public DataTable RetDataTable(string sql)
        {
            DataTable data = new DataTable();
            MySqlCommand Command = new MySqlCommand(sql, Connection);
            MySqlDataAdapter da = new MySqlDataAdapter(Command);
            da.Fill(data);
            return data;
        }

        public DataTable RetDataTable(MySqlCommand Command)
        {
            DataTable data = new DataTable();
            Command.Connection = Connection;
            MySqlDataAdapter da = new MySqlDataAdapter(Command);
            da.Fill(data);
            return data;
        }

        //Espera um parâmetro do tipo string 
        //contendo um comando SQL do tipo INSERT, UPDATE, DELETE
        public void ExecutarComandoSQL(string sql)
        {
            MySqlCommand Command = new MySqlCommand(sql, Connection);
            Command.ExecuteNonQuery();
        }
    }
}
