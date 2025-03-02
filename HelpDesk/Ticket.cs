using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using static TheArtOfDev.HtmlRenderer.Adapters.RGraphicsPath;

namespace HelpDesk
{
    public class Ticket
    {
        public string TicketID { get; set; }
        public Contact Person { get; set; }  // User who created the ticket
        public TicketPriority Priority { get; set; }
        public TicketType Type { get; set; }
        public string Topic { get; set; }
        public string Reference { get; set; }
        public string Details { get; set; }
        public TicketStatus Status { get; set; }
        public DateTime OpenDate { get; set; }
        public DateTime? CloseDate { get; set; }
        public Employee AssignedWorker { get; set; }

        public Ticket(Contact person, TicketPriority priority, TicketType type, TicketStatus status, string topic, string reference, string details)
        {
            TicketID = Guid.NewGuid().ToString();
            Person = person;
            Priority = priority;
            Type = type;
            Topic = topic;
            Reference = reference;
            Details = details;
            Status = TicketStatus.Open;
            OpenDate = DateTime.Now;
            CloseDate = null;
            AssignedWorker = null;
        }
        
        public enum TicketStatus
        {
            Open,
            InProgress,
            Closed
        }
        public enum TicketType
        {
            Incident,
            ServiceRequest,
            BugReport,
            Other
        }
        public enum TicketPriority
        {
            Low,
            Medium,
            High,
            Critical
        }
    }
}
