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

            ContextMenu cmSubjects = new ContextMenu();
            cmSubjects.MenuItems.Add("Neues Treffen", new EventHandler(SubjectsItemClick));
            cmSubjects.MenuItems.Add("Bearbeiten", new EventHandler(SubjectsItemClick));
            cmSubjects.MenuItems.Add("Löschen", new EventHandler(SubjectsItemClick));
            lbSubjects.ContextMenu = cmSubjects;
            lbSubjects.MouseDown += lbSubjects_MouseDown;

            ContextMenu cmPeople = new ContextMenu();
            cmPeople.MenuItems.Add("Bearbeiten", new EventHandler(PeopleItemClick));
            cmPeople.MenuItems.Add("Löschen", new EventHandler(PeopleItemClick));
            lbParticipants.ContextMenu = cmPeople;
            lbParticipants.MouseDown += lbPeople_MouseDown;
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
            }
        }

        void PeopleItemClick(object sender, EventArgs e)
        {
            if (lbParticipants.SelectedIndex != -1)
            {
                MenuItem clickedItem = sender as MenuItem;
                switch (clickedItem.Text)
                {
                    case "Bearbeiten":
                        EditPersonForm input = new EditPersonForm(this, DS.Participants.ElementAt(lbParticipants.SelectedIndex).Name, DS.Participants.ElementAt(lbParticipants.SelectedIndex).Days);
                        input.ShowDialog();
                        if (NewPeopleNames.Count > 0)
                        {
                            DS.Participants.ElementAt(lbParticipants.SelectedIndex).Name = NewPeopleNames.ElementAt(0);
                            DS.Participants.ElementAt(lbParticipants.SelectedIndex).Days = NewPeopleDays.ElementAt(0);
                            NewPeopleNames.Clear();
                            NewPeopleDays.Clear();
                            lbParticipants.DataSource = null;
                            lbParticipants.DisplayMember = "Name";
                            lbParticipants.ValueMember = "ID";
                            lbParticipants.DataSource = DS.Participants;
                        }
                        break;
                    case "Löschen":
                        DS.Participants.RemoveAt(lbParticipants.SelectedIndex);
                        break;
                }
            }
        }

        private void lbPeople_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //select the item under the mouse pointer
                lbParticipants.SelectedIndex = lbParticipants.IndexFromPoint(e.Location);
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
            NewPeopleNames.Clear();
            NewPeopleDays.Clear();
        }
    }
}