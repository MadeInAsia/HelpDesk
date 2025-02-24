using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk
{
    class Statuse
    {
        public int ID { get; set; }
        public string Status { get; set; }
        public Statuse(int iD, string status)
        {
            ID = iD;
            Status = status;
        }
    }
}
