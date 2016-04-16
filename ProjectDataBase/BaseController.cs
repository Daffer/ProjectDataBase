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
        public void Initialization()
        {
            /*string[] FindSQL = Directory.GetFiles("C:","BMSTU");
            string CurrentDirectory = Directory.GetCurrentDirectory();
            string[] Findfile = Directory.GetFiles(CurrentDirectory);
            /if (Findfile.Count<string>() <= 0)
            //    File.Open(CurrentDirectory + "//Authorization.au", FileMode.Create);
            //else
            //    File.Open(CurrentDirectory + "//Authorization.au", FileMode.Open);
            //File.ReadAllBytes()
            //DataBase = FindSQL[0];
            /*SecureString pwd = new SecureString();
            char[] res = { 'C','a','t','1','9','9','5','0','2','1','4' };
            for (int I = 0; I < res.Length ; I++)
                pwd.AppendChar(res[I]);
            pwd.MakeReadOnly();
            string Name = "PavelAdmin";*/
            //
            //Communication = new SqlConnection(DataBase,Credential);
            //Communication.Open();
            //Communication = new SqlConnection(DataBase, Credential);
            //SqlDataAdapter adapter = new SqlDataAdapter(); //создаем адаптер для связи с данными. 
            //return;*/
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
        

        static private SqlExceptionHelp ErrorHelp;
        static private string DataBase;
        static private SqlConnection Communication;
    }
}
