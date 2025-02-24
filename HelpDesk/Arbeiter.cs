using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk
{
    class Arbeiter
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Nachname { get; set; }

        public Arbeiter(int iD, string name, string nachname)
        {
            ID = iD;
            Name = name;
            Nachname = nachname;
        }
    }
}
