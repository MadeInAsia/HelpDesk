using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Nachname { get; set; }
        public string Department { get; set; }

        public Employee(int iD, string name, string nachname, string department)
        {
            ID = iD;
            Name = name;
            Nachname = nachname;
            Department = department; 
        }
    }
}
