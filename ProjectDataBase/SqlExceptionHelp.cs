using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProjectDataBase
{
    class SqlExceptionHelp
    {
        public event EventHandler<string> ErrorMsg;
        public void EnterError(SqlException error)
        {
            EventHandler<string> handler = ErrorMsg;
            handler(this, error.Message);
        }
        public void CredentialErr(Exception error)
        {
            EventHandler<string> handler = ErrorMsg;
            handler(this, error.Message);
        }
        public void ConnectionErr(Exception error)
        {
            EventHandler<string> handler = ErrorMsg;
            handler(this, error.Message);
        }

        public void GetUserErr(Exception error)
        {
            EventHandler<string> handler = ErrorMsg;
            handler(this, error.Message);
        }
        public void ParticipantErr(Exception error)
        {
            EventHandler<string> handler = ErrorMsg;
            handler(this, error.Message);
        }
        public void CheckLoginErr(SqlException error)
        {
            EventHandler<string> handler = ErrorMsg;
            handler(this, error.Message);
        }
        public void CreateUserErr(Exception error)
        {
            EventHandler<string> handler = ErrorMsg;
            handler(this, error.Message);
        }
        public void CreateUserErr(SqlException error)
        {
            EventHandler<string> handler = ErrorMsg;
            handler(this, error.Message);
        }
    }
}
