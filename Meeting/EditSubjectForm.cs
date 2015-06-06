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
    public partial class EditSubjectForm : Form
    {

        private MainForm Parent;

        public EditSubjectForm(MainForm parent, string name)
        {
            InitializeComponent();
            this.Parent = parent;
            tbName.Text = name;
            tbName.SelectAll();
            tbName.KeyDown += new KeyEventHandler(tb_KeyDown);
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            saveName();
        }

        private void saveName()
        {
            Parent.NewSubjectsNames.Add(tbName.Text);
            Close();
        }

        private void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                saveName();
            }
        }
    }
}
