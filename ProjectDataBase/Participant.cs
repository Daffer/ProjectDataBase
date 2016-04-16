using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProjectDataBase
{
    class Participant
    {
        private string Login;
        private string SurName;
        private string Name;
        private string SecondName;
        private int ID;
        private string Email;
        private string Location;
        private int Priority;
        public void Information(object[] Info)
        {
            try
            {
                ID = Convert.ToInt32(Info[0]);
                Login =  Info[1].ToString();
                SurName = Info[2].ToString();
                Name = Info[3].ToString();
                SecondName = Info[4].ToString();
                Email = Info[5].ToString();
                Location = Info[6].ToString();
                Priority = Convert.ToInt32(Info[7]);
            }
            catch(Exception error)
            {
                Program.Base.GetException().ParticipantErr(error);
            }
        }
    }
}
