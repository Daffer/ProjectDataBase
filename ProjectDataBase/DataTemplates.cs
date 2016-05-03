using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectDataBase
{
    public enum TypeData { List, Personal};
    class DataTemplates
    {
        public void Initialization(GroupBox ControlledBox)
        {
            Control = ControlledBox;
            Type = TypeData.List;
        }
        public void Processors()
        {

        }
        private GroupBox Control;
        private TypeData Type;
    }
}
