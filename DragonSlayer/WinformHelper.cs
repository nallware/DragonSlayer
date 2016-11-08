using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragonSlayer
{
    public static class WinformHelper
    {


        public static class ControlHelper
        {
            public static List<Control> AllControls(Control container)
            {
                var list = container.Controls.OfType<Control>().ToList();
                var deep = list.Where(o => o.Controls.Count > 0).SelectMany(AllControls).ToList();
                list.AddRange(deep);
                return list;
            }


            public static IEnumerable<Control> GetAllTextBoxControls(Control container)
            {
                List<Control> controlList = new List<Control>();
                foreach (Control c in container.Controls)
                {
                    controlList.AddRange(GetAllTextBoxControls(c));

                    if (c is TextBox) controlList.Add(c);
                }
                return controlList;
            }


            public static IEnumerable<Control> GetAllComboBoxControls(Control container)
            {
                List<Control> controlList = new List<Control>();
                foreach (Control c in container.Controls)
                {
                    controlList.AddRange(GetAllComboBoxControls(c));

                    if (c is ComboBox) controlList.Add(c);
                }
                return controlList;
            }

            public static IEnumerable<Control> GetAllSearchControls(Control container)
            {
                List<Control> controlList = new List<Control>();
                foreach (Control c in container.Controls)
                {
                    controlList.AddRange(GetAllSearchControls(c));

                    controlList.Add(c);
                }
                return controlList;
            }
        }


    }
}
