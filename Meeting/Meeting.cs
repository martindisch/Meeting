using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meeting
{
    class Meeting
    {
        public int Subject;
        public int[] Participants;

        public Meeting(int Subject, int[] Participants)
        {
            this.Subject = Subject;
            this.Participants = Participants;
        }
    }
}
