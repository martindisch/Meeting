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
    public partial class NewPersonForm : Form
    {
        private MainForm Parent;

        public NewPersonForm(MainForm parent)
        {
            InitializeComponent();
            this.Parent = parent;
            tbName.KeyDown += new KeyEventHandler(tb_KeyDown);
        }

        private void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                savePerson();
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            savePerson();
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

            tbName.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
