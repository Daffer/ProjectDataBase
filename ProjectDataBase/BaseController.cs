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
            //string[] FindSQL = Directory.GetFiles("C:","BMSTU");
            //string CurrentDirectory = Directory.GetCurrentDirectory();
            //string[] Findfile = Directory.GetFiles(CurrentDirectory);
            //if (Findfile.Count<string>() <= 0)
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
            //DataBase = @"Data Source = DAFFER\SQLEXPRESS;Initial Catalog=Terminal;";
            //Communication = new SqlConnection(DataBase,Credential);
            //Communication.Open();
            //Communication = new SqlConnection(DataBase, Credential);
            //SqlDataAdapter adapter = new SqlDataAdapter(); //создаем адаптер для связи с данными. 
            //return;

        }

        public string ConnectToDataBase(string Name, SecureString Password)
        {
            string State;
            try
            {
                Credential = new SqlCredential(Name, Password);
                State = Connecting();
            }
            catch(Exception Error)
            {
                State = Error.Message;
            }
            return State;
        }

        private string Connecting()
        {
            try
            {
                Communication = new SqlConnection(DataBase, Credential);
                return "Соедение установлено";
            }
            catch (SqlException error)
            {
                return error.Message;
                //ErrorsHelper.EnterError(error);
            }
        }
        

        public string CreateUser(string Name,SecureString Password)
        {
            if (true)//CheckName(Name) == 0)
            {
                try
                { 
                    Credential = new SqlCredential(Name, Password);
                    //return State;
                }
                catch(Exception error)
                {
                    //return error.Message;
                }
            }
            else
            {

            }
            return "Error";
        }
        private SqlExceptionHelp ErrorsHelper;
        static private SqlCredential Credential;
        static private string DataBase;
        static private SqlConnection Communication;
    }
}
