using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk
{
    public class Contact
    {
        public string Name { get; set; }
        public string Nachname { get; set; }
        public string Email { get; set; }

        public Contact(string name, string nachname, string email)
        {
            Name = name;
            Nachname = nachname;
            Email = email;
        }
    }
}
