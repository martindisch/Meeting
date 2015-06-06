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
    public partial class MainForm : Form
    {

        private Dataset DS;
        public List<String> NewNames;

        public MainForm()
        {
            InitializeComponent();
            DS = new Dataset();
            lbSubjects.DataSource = DS.Subjects;
            lbSubjects.DisplayMember = "Name";
            lbSubjects.ValueMember = "ID";
            NewNames = new List<String>();
        }

        private void bAddSubject_Click(object sender, EventArgs e)
        {
            SubjectForm input = new SubjectForm(this);
            input.ShowDialog();
            for (int i = 0; i < NewNames.Count; i++)
            {
                DS.Subjects.Add(new Subject(DS.GetNextId(), NewNames.ElementAt(i)));
            }
            NewNames.Clear();
        }
    }
}
