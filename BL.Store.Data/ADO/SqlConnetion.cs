using System;
using System.Data.SqlClient;

namespace BL.Store.Data.ADO
{
    internal class SqlConnetion
    {
        private string connString;

        public SqlConnetion(string connString)
        {
            this.connString = connString;
        }

        public object State { get; internal set; }

        internal void Open()
        {
            throw new NotImplementedException();
        }

        public static implicit operator SqlConnection(SqlConnetion v)
        {
            throw new NotImplementedException();
        }

        internal void Close()
        {
            throw new NotImplementedException();
        }
    }
}