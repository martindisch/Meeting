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
    public partial class Form1 : Form
    {

        private Dataset ds;

        public Form1()
        {
            InitializeComponent();
            ds = new Dataset();
        }

        private void bAddSubject_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ds.getNextId() + "");
            ds.subjects.Add(new Subject(1, "test"));
        }
    }
}
