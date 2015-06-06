using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meeting
{
    class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int[] Days { get; set; }

        public Person(int id, string name, int[] days)
        {
            this.ID = id;
            this.Name = name;
            this.Days = days;
        }
    }
}
