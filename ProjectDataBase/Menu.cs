using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ProjectDataBase
{
    public enum MenuType { MainMenu, SideBar};
    class Menu
    {
        public void Initialization(GroupBox ControlledBox)
        {
            Type = MenuType.MainMenu;
            Control = ControlledBox;
        }

        public void TransformOnSideBar(int Height,int Width,int Interval = 10)
        {
            if (Type == MenuType.SideBar)
                return;
            Control.Size = new Size(Width, Height);
            int ControlsHeight = Height / Control.Controls.Count - Interval/2;
            for (int I = 0; I<Control.Controls.Count; I++)
            {
                Control.Controls[I].Size = new Size(Width, ControlsHeight);
                Control.Controls[I].Location = new Point(0,Interval+I*ControlsHeight);
            }
            return;
        }

        public void TransformOnMainMenu(int Height, int Width, int Interval = 30)
        {
            if (Type == MenuType.MainMenu)
                return;
            Control.Size = new Size(Width, Height);
            int ControlsHeight = Height / Control.Controls.Count - Interval / 2;
            int CurrentWidth = 0;
            int CurrentHeith = 0;
            for (int I = Control.Controls.Count-1; I >= 0; I--)
            {
                Control.Controls[I].Size = new Size(Width, ControlsHeight);
                Control.Controls[I].Location = new Point(0, Interval + I * ControlsHeight);
            }
            return;
        } 
        private MenuType Type;
        private GroupBox Control;
    }

    
}
