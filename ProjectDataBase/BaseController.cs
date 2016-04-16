using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.IO;
using System.Security;

namespace ProjectDataBase
{
    class BaseController
    {
        string GetUser = "Select * from dbo.GetUser(N'";
        public void Initialization()
        {
            /*string[] FindSQL = Directory.GetFiles("C:","BMSTU");
            string CurrentDirectory = Directory.GetCurrentDirectory();
            string[] Findfile = Directory.GetFiles(CurrentDirectory);
            if (Findfile.Count<string>() <= 0)
                File.Open(CurrentDirectory + "//Authorization.au", FileMode.Create);
            else
                File.Open(CurrentDirectory + "//Authorization.au", FileMode.Open);
            File.ReadAllBytes()
            Communication = new SqlConnection(DataBase,Credential);
            Communication.Open();
            Communication = new SqlConnection(DataBase, Credential);
            SqlDataAdapter adapter = new SqlDataAdapter(); //создаем адаптер для связи с данными. 
            return;*/
            DataBase = @"Data Source = DAFFER\SQLEXPRESS;Initial Catalog=Terminal;";
            ErrorHelp = new SqlExceptionHelp();
            
        }
        public SqlExceptionHelp GetException()
        {
            return ErrorHelp;
        }
        public bool ConnectToDataBase(string Name, SecureString Password)
        {
            try
            {
                SqlCredential Credential = new SqlCredential(Name, Password);
                if (Credential != null)
                {
                    Connecting(Credential);
                }
                GetInfoOfUser(Name);
                return true;
            }
            catch(Exception Error)
            {
                ErrorHelp.CredentialErr(Error);
                return false;
            }
        }

        private void Connecting(SqlCredential Credential)
        {
            try
            {
                Communication = new SqlConnection(DataBase, Credential);
                if (Communication != null)
                {
                    Communication.Open();
                    Exception State = new Exception("Соединение установлено");
                    ErrorHelp.ConnectionErr(State);
                }
            }
            catch (SqlException error)
            {
                ErrorHelp.EnterError(error);
            }
        }

        public bool Registration()
        {
            return false;
        }
        
        private bool GetInfoOfUser(string Name)
        {
            try
            {
                SqlDataAdapter Adapter = new SqlDataAdapter();
                if (Adapter == null)
                    return false;
                string Query = GetUser + Name + "')";
                SqlCommand Command = new SqlCommand(Query, Communication);
                if (Command == null)
                    return false;
                SqlDataReader Reader = Command.ExecuteReader();

            }
            catch(SqlException error)
            {
                ErrorHelp.GetUserErr(error);
            }
            return true;
        }

        static private SqlExceptionHelp ErrorHelp;
        static private string DataBase;
        static private SqlConnection Communication;
    }
}
