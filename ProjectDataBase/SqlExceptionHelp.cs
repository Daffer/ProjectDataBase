﻿using System;
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
    }
}
