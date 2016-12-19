using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
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


        public static void AddDGVButtons(DataGridView dgvMain)
        {
            DataGridViewButtonColumn updateCol = new DataGridViewButtonColumn();
            updateCol.Name = "Update";
            updateCol.Text = "Update";
            updateCol.UseColumnTextForButtonValue = true;
            if (dgvMain.Columns["Update"] == null)
            {
                dgvMain.Columns.Add(updateCol);
            }
            DataGridViewButtonColumn deleteCol = new DataGridViewButtonColumn();
            deleteCol.Name = "Delete";
            deleteCol.Text = "Delete";
            deleteCol.UseColumnTextForButtonValue = true;
            if (dgvMain.Columns["Delete"] == null)
            {
                dgvMain.Columns.Add(deleteCol);
            }
            DataGridViewButtonColumn insertCol = new DataGridViewButtonColumn();
            insertCol.Name = "Insert";
            insertCol.Text = "Insert";
            insertCol.UseColumnTextForButtonValue = true;
            if (dgvMain.Columns["Insert"] == null)
            {
                dgvMain.Columns.Add(insertCol);
            }
            dgvMain.Columns["EquipmentId"].ReadOnly = true;
            dgvMain.Columns["EquipmentId"].DefaultCellStyle.BackColor = SystemColors.GradientInactiveCaption;
            dgvMain.Columns["EquipmentId"].DefaultCellStyle.ForeColor = SystemColors.InactiveCaptionText;
            dgvMain.Columns["EquipmentId"].DefaultCellStyle.SelectionBackColor = SystemColors.InactiveCaption;
            dgvMain.Columns["EquipmentId"].DefaultCellStyle.SelectionForeColor = SystemColors.InactiveCaptionText;
            //DefaultCellStyle.ForeColor = SystemColors.InactiveCaptionText;
            //DataGridViewButtonColumn dCol = new DataGridViewButtonColumn();
            //dCol.Name = "nil";
            //if (dgvMain.Columns["nil"] == null)
            //{
            //    dgvMain.Columns.Add(dCol);
            //}

        }

    }
}
