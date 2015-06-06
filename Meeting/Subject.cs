using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meeting
{
    class Subject
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Subject(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }
    }
}
