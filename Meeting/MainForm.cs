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
            ContextMenu cm = new ContextMenu();
            cm.MenuItems.Add("Neues Treffen", new EventHandler(item_click));
            cm.MenuItems.Add("Bearbeiten", new EventHandler(item_click));
            cm.MenuItems.Add("Löschen", new EventHandler(item_click));
            lbSubjects.ContextMenu = cm;
            lbSubjects.MouseDown += lbSubjects_MouseDown;
        }

        void item_click(object sender, EventArgs e)
        {
            MenuItem clickedItem = sender as MenuItem;
            switch (clickedItem.Text)
            {
                case "Neues Treffen":
                    
                    break;
                case "Bearbeiten":

                    break;
                case "Löschen":
                    if (lbSubjects.SelectedIndex != -1)
                    {
                        DS.Subjects.RemoveAt(lbSubjects.SelectedIndex);
                    }
                    break;
            }
        }

        private void lbSubjects_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //select the item under the mouse pointer
                lbSubjects.SelectedIndex = lbSubjects.IndexFromPoint(e.Location);
                if (lbSubjects.SelectedIndex != -1)
                {
                    //listboxContextMenu.Show();
                }
            }
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
