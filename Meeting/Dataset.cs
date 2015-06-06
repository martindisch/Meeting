using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meeting
{
    class Dataset
    {
        private int NextID;

        public BindingList<Subject> Subjects { get; set; }
        public BindingList<Person> Participants { get; set; }
        public BindingList<Meeting> Meetings { get; set; }

        public Dataset()
        {
            NextID = 0;
            Subjects = new BindingList<Subject>();
            Participants = new BindingList<Person>();
            Meetings = new BindingList<Meeting>();
        }

        public int GetNextId()
        {
            return NextID++;
        }
    }
}
