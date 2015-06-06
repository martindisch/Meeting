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
        public List<String> NewSubjectsNames;
        public List<String> NewPeopleNames;
        public List<bool[]> NewPeopleDays;

        public MainForm()
        {
            InitializeComponent();
            DS = new Dataset();

            lbSubjects.DataSource = DS.Subjects;
            lbSubjects.DisplayMember = "Name";
            lbSubjects.ValueMember = "ID";

            lbParticipants.DataSource = DS.Participants;
            lbParticipants.DisplayMember = "Name";
            lbParticipants.ValueMember = "ID";

            NewSubjectsNames = new List<String>();
            NewPeopleNames = new List<String>();
            NewPeopleDays = new List<bool[]>();

            ContextMenu cm = new ContextMenu();
            cm.MenuItems.Add("Neues Treffen", new EventHandler(SubjectsItemClick));
            cm.MenuItems.Add("Bearbeiten", new EventHandler(SubjectsItemClick));
            cm.MenuItems.Add("Löschen", new EventHandler(SubjectsItemClick));
            lbSubjects.ContextMenu = cm;
            lbSubjects.MouseDown += lbSubjects_MouseDown;
        }

        void SubjectsItemClick(object sender, EventArgs e)
        {
            if (lbSubjects.SelectedIndex != -1)
            {
                MenuItem clickedItem = sender as MenuItem;
                switch (clickedItem.Text)
                {
                    case "Neues Treffen":

                        break;
                    case "Bearbeiten":
                        EditSubjectForm input = new EditSubjectForm(this, DS.Subjects.ElementAt(lbSubjects.SelectedIndex).Name);
                        input.ShowDialog();
                        if (NewSubjectsNames.Count > 0)
                        {
                            DS.Subjects.ElementAt(lbSubjects.SelectedIndex).Name = NewSubjectsNames.ElementAt(0);
                            NewSubjectsNames.Clear();
                            lbSubjects.DataSource = null;
                            lbSubjects.DisplayMember = "Name";
                            lbSubjects.ValueMember = "ID";
                            lbSubjects.DataSource = DS.Subjects;
                        }
                        break;
                    case "Löschen":
                        DS.Subjects.RemoveAt(lbSubjects.SelectedIndex);
                        break;
                }
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
            NewSubjectForm input = new NewSubjectForm(this);
            input.ShowDialog();
            for (int i = 0; i < NewSubjectsNames.Count; i++)
            {
                DS.Subjects.Add(new Subject(DS.GetNextId(), NewSubjectsNames.ElementAt(i)));
            }
            NewSubjectsNames.Clear();
        }

        private void bAddParticipants_Click(object sender, EventArgs e)
        {
            NewPersonForm input = new NewPersonForm(this);
            input.ShowDialog();
            for (int i = 0; i < NewPeopleNames.Count; i++)
            {
                DS.Participants.Add(new Person(DS.GetNextId(), NewPeopleNames.ElementAt(i), NewPeopleDays.ElementAt(i)));
            }
            NewSubjectsNames.Clear();
        }
    }
}
