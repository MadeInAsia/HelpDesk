using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk
{
    class Types
    {
        public int id { get; set; }
        public string ticketType { get; set; }
        public Types(int id, string ticketType)
        {
            this.id = id;
            this.ticketType = ticketType;
        }
    }
}
