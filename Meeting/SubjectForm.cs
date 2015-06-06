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
    public partial class SubjectForm : Form
    {
        private MainForm Parent;

        public SubjectForm(MainForm parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            Parent.NewNames.Add(tbName.Text);
        }
    }
}
