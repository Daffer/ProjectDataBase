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
        public string NameOperation
        {
            get { return Name; }
            set { Name = value; }
        }
        public int IDOperation
        {
            get { return ID; }
            set { ID = value; }
        }
    }
}
