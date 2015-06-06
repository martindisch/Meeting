using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meeting
{
    class Person
    {
        public int ID;
        public string Name;
        public int[] Days;

        public Person(int ID, string Name, int[] Days)
        {
            this.ID = ID;
            this.Name = Name;
            this.Days = Days;
        }
    }
}
