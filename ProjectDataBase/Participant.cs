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
        private string Name;
        private int ID;
        private string Email;
        private string Location;
        private int Priority;
        public string NameOp
        {
            get { return Name; }
            set { Name = value; }
        }
        public int IDOp
        {
            get { return ID; }
            set { ID = value; }
        }
        public string EmailOp
        {
            get { return Email; }
            set { Email = value; }
        }
        public string LocationOp
        {
            get { return Location; }
            set { Location = value; }
        }
        public int PriorityOp
        {
            get { return Priority; }
            set { Priority = value; }
        }
    }
}
