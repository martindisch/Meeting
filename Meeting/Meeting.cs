using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meeting
{
    class Meeting
    {
        public int Subject { get; set; }
        public int[] Participants { get; set; }

        public Meeting(int subject, int[] participants)
        {
            this.Subject = subject;
            this.Participants = participants;
        }
    }
}
