using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meeting
{
    public partial class EditPersonForm : Form
    {
        MainForm Parent;

        public EditPersonForm(MainForm parent, string name, bool[] days)
        {
            InitializeComponent();
            this.Parent = parent;
            tbName.Text = name;
            if (days[0])
            {
                checkBox1.Checked = true;
            }
            if (days[1])
            {
                checkBox2.Checked = true;
            }
            if (days[2])
            {
                checkBox3.Checked = true;
            }
            if (days[3])
            {
                checkBox4.Checked = true;
            }
            if (days[4])
            {
                checkBox5.Checked = true;
            }
            tbName.SelectAll();
            tbName.KeyDown += new KeyEventHandler(tb_KeyDown);
        }

        private void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                savePerson();
            }
        }

        private void savePerson()
        {
            Parent.NewPeopleNames.Add(tbName.Text);
            bool[] days = new bool[] { false, false, false, false, false };
            if (checkBox1.Checked)
            {
                days[0] = true;
            }
            if (checkBox2.Checked)
            {
                days[1] = true;
            }
            if (checkBox3.Checked)
            {
                days[2] = true;
            }
            if (checkBox4.Checked)
            {
                days[3] = true;
            }
            if (checkBox5.Checked)
            {
                days[4] = true;
            }
            Parent.NewPeopleDays.Add(days);

            Close();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            savePerson();
        }
    }
}
