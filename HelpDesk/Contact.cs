using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk
{
    class Contact
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Nachname { get; set; }
        public string Email { get; set; }
        public string Abteilung { get; set; }

        public Contact(int iD, string name, string nachname, string email, string abteilung)
        {
            ID = iD;
            Name = name;
            Nachname = nachname;
            Email = email;
            Abteilung = abteilung;
        }
    }
}
