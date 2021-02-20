using System;
using System.Configuration;
using System.Data.SqlClient;

namespace BL.Store.Data.ADO
{
    public class BLStoreDataContextADO : IDisposable
    {
        private readonly SqlConnetion _conn;
        public BLStoreDataContextADO()
        {
            var connString = ConfigurationManager.ConnectionStrings["StoreConn"].ConnectionString;
            _conn = new SqlConnetion(connString);
            _conn.Open();
        }

        public void ExecuteCommand(string sql)
        {
            var command = new SqlCommand() { 
                CommandText = sql,
                CommandType = System.Data.CommandType.Text,
                Connection = _conn
            };
            command.ExecuteNonQuery();
        }

        public SqlDataReader ExecuteCommandaWithData(string query) {
            var command = new SqlCommand(query, _conn);
            return command.ExecuteReader();
        }

        public void Dispose()
        {
            if (_conn.State != System.Data.ConnectionState.Open)
            {
                return;
            }
            _conn.Close();
        }
    }
}
