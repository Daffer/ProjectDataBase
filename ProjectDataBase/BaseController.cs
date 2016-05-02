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
        private string GetUser = "Select * from dbo.GetUser(N'";
        private string CheckLoginQuery = "Select dbo.VerificationLogin(N'";
        private string CreateUser = "CreateNewUser";
        public void Initialization()
        {
            ErrorHelp = new SqlExceptionHelp();
            DataBase = @"Data Source = DAFFER\SQLEXPRESS;Initial Catalog=Terminal;";
            string Name = "Guest";
            SecureString Pwd = new SecureString();
            string Pass = "";
            for (int I = 0; I < Pass.Length; I++)
                Pwd.AppendChar(Pass[I]);
            Pwd.MakeReadOnly();
            ConnectToDataBase(Name, Pwd);
               
        }
        public SqlExceptionHelp GetException()
        {
            return ErrorHelp;
        }
        public bool ConnectToDataBase(string Name, SecureString Password)
        {
            try
            {
                bool StateConnection = false;
                SqlCredential Credential = new SqlCredential(Name, Password);
                if (Credential != null)
                {
                    StateConnection = Connecting(Credential);
                }
                if (StateConnection != true)
                    return false;
                if (Name == "Guest")
                    return true;
                User = new Participant();
                if (User == null)
                    return false;
                StateConnection = GetInfoOfUser(Name);
                if (StateConnection == false)
                    return false;
                return true;
            }
            catch(Exception Error)
            {
                ErrorHelp.CredentialErr(Error);
                return false;
            }
        }

        private bool Connecting(SqlCredential Credential)
        {
            try
            {
                Communication = new SqlConnection(DataBase, Credential);
                if (Communication != null)
                {
                    Communication.Open();
                    //Exception State = new Exception("Соединение установлено");
                    //ErrorHelp.ConnectionErr(State);
                    return true;
                }
            }
            catch (SqlException error)
            {
                ErrorHelp.EnterError(error);
            }
            return false;
        }

        public bool Registration(string Login, string Password, string Surname, string Name, string SecondName, string Email, string Location, string Role)
        {
            try
            {
                int State = 1;
                State = CreateNewUser(Login, Password, Surname, Name, SecondName, Email, Location, Role);
                if (State != 0)
                    return false;
                SecureString Pwd = new SecureString();
                for (int I = 0; I<Password.Length; I++)
                {
                    Pwd.AppendChar(Password[I]);
                }
                bool StatusConnect = ConnectToDataBase(Login, Pwd);
                return StatusConnect;

            }
            catch(SqlException error)
            {
                ErrorHelp.CreateUserErr(error);
                return false;
            }
            catch(Exception error)
            {
                ErrorHelp.CreateUserErr(error);
                return false;
            }
            return true;
        }
        
        private bool GetInfoOfUser(string Name)
        {
            try
            {
                string Query = GetUser + Name + "')";
                SqlCommand Command = new SqlCommand(Query, Communication);
                if (Command == null)
                    return false;
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read() == false)
                {
                    return false;
                }
                object[] Information = {null,null,null,null,null,null,null,null};
                Reader.GetValues(Information);
                User.Information(Information);
                Reader.Close();
            }
            catch(SqlException error)
            {
                ErrorHelp.GetUserErr(error);
            }
            return true;
        }

        public bool CheckLogin(string Login)
        {
            try
            {
                string Query = CheckLoginQuery + Login + "')go";
                SqlCommand Command = new SqlCommand(Query, Communication);
                int Result = Convert.ToInt32(Command.ExecuteScalar());
                if (Result== 1)
                {
                    return false;
                }
                return true;
            }
            catch(SqlException error)
            {
                ErrorHelp.CheckLoginErr(error);
                return false;
            }
        }

        private int CreateNewUser(string Login, string Password, string Surname, string Name, string SecondName, string Email, string Location, string Role)
        {
            SqlCommand Command = Communication.CreateCommand();
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = CreateUser;
            int Res = 1;
            SqlParameter[] InputParam = new SqlParameter[8];
            InputParam[0] = Command.Parameters.Add("@Login", SqlDbType.NVarChar);
            InputParam[0].Direction = ParameterDirection.Input;
            InputParam[0].Value = Login;
            InputParam[1] = Command.Parameters.Add("@Password", SqlDbType.NVarChar);
            InputParam[1].Direction = ParameterDirection.Input;
            InputParam[1].Value = Password;
            InputParam[2] = Command.Parameters.Add("@Surname", SqlDbType.NVarChar);
            InputParam[2].Direction = ParameterDirection.Input;
            InputParam[2].Value = Surname;
            InputParam[3] = Command.Parameters.Add("@Name", SqlDbType.NVarChar);
            InputParam[3].Direction = ParameterDirection.Input;
            InputParam[3].Value = Name;
            InputParam[4] = Command.Parameters.Add("@SecondName", SqlDbType.NVarChar);
            InputParam[4].Direction = ParameterDirection.Input;
            InputParam[4].Value = SecondName;
            InputParam[5] = Command.Parameters.Add("@Email", SqlDbType.NVarChar);
            InputParam[5].Direction = ParameterDirection.Input;
            InputParam[5].Value = Email;
            InputParam[6] = Command.Parameters.Add("@Location", SqlDbType.NVarChar);
            InputParam[6].Direction = ParameterDirection.Input;
            InputParam[6].Value = Location;
            InputParam[7] = Command.Parameters.Add("@Role", SqlDbType.NVarChar);
            InputParam[7].Direction = ParameterDirection.Input;
            InputParam[7].Value = Role;
            SqlParameter Result = Command.Parameters.Add("return_value", SqlDbType.Int);
            Result.Direction = ParameterDirection.ReturnValue;
            SqlDataReader Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                Res = Convert.ToInt32(Reader[0]);
            }
            Reader.Close();
            return Res;
        }

        static private Participant User;
        static private SqlExceptionHelp ErrorHelp;
        static private string DataBase;
        static private SqlConnection Communication;
    }
}
