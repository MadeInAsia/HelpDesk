using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk
{
    class Ticket
    {
        private int ticketID;
        private Types type;
        private Contact contact;
        private string description;
        private Statuse status;
        private string priority;
        private string openDate;
        private string openTime;
        private string closeDate;
        private string closeTime;
        private string responseTime;
        private string resoltuionTime;
        private Arbeiter abtretungsempfänger;

        public Ticket(int ticketID, Types type, Contact contact, string description, Statuse status, string priority, string openDate, 
            string openTime, string closeDate, string closeTime, string responseTime, string resoltuionTime, Arbeiter abtretungsempfänger)
        {
            this.ticketID = ticketID;
            this.type = type;
            this.contact = contact;
            this.description = description;
            this.status = status;
            this.priority = priority;
            this.openDate = openDate;
            this.openTime = openTime;
            this.closeDate = closeDate;
            this.closeTime = closeTime;
            this.responseTime = responseTime;
            this.resoltuionTime = resoltuionTime;
            this.abtretungsempfänger = abtretungsempfänger;
        }

        public int TicketID { get => ticketID; set => ticketID = value; }
        public string Description { get => description; set => description = value; }
        public string Priority { get => priority; set => priority = value; }
        public string OpenDate { get => openDate; set => openDate = value; }
        public string OpenTime { get => openTime; set => openTime = value; }
        public string CloseDate { get => closeDate; set => closeDate = value; }
        public string CloseTime { get => closeTime; set => closeTime = value; }
        public string ResponseTime { get => responseTime; set => responseTime = value; }
        public string ResoltuionTime { get => resoltuionTime; set => resoltuionTime = value; }
        internal Types Type { get => type; set => type = value; }
        internal Contact Contact { get => contact; set => contact = value; }
        internal Statuse Status { get => status; set => status = value; }
        internal Arbeiter Abtretungsempfänger { get => abtretungsempfänger; set => abtretungsempfänger = value; }
    }
}
