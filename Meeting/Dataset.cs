using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meeting
{
    class Dataset
    {
        private int NextID;

        public List<Subject> Subjects;
        public List<Person> Participants;
        public List<Meeting> Meetings;

        public Dataset()
        {
            NextID = 0;
            Subjects = new List<Subject>();
            Participants = new List<Person>();
            Meetings = new List<Meeting>();
        }

        public int GetNextId()
        {
            return NextID++;
        }
    }
}
