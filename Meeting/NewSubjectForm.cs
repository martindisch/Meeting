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
    public partial class NewSubjectForm : Form
    {
        private MainForm Parent;

        public NewSubjectForm(MainForm parent)
        {
            InitializeComponent();
            Parent = parent;
            tbName.KeyDown += new KeyEventHandler(tb_KeyDown);
        }

        private void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                saveName();
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            saveName();
        }

        private void saveName()
        {
            Parent.NewSubjectsNames.Add(tbName.Text);
            tbName.Clear();
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
