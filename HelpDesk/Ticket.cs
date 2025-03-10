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
        public List<String> Comments { get; private set; } //List of status updates


        public Ticket(Contact person, TicketPriority priority, TicketType type, TicketStatus status, string topic, string reference, string details, Employee assignedWorker = null)
        {
            TicketID = Guid.NewGuid().ToString();
            Person = person;
            Priority = priority;
            Type = type;
            Topic = topic;
            Reference = reference;
            Details = details;
            Status = status;
            OpenDate = DateTime.Now;
            CloseDate = null;
            AssignedWorker = assignedWorker;
            Comments = new List<string>();

            LogComment("Ticket created by " + person.Name + person.Nachname); 

            // change this so that the listbox only shows the ticket instance once, not from user and admin at the same time only one and other or so 
        }

        private void LogComment(string message)
        {
            string timestamp = DateTime.Now.ToString();
            Comments.Add(timestamp + " : " + message);
        }

        public void AssignWorker(Employee employee)
        {
            AssignedWorker = employee;
            LogComment("Assigned to " + employee.Name + " " + employee.Nachname);
        }

        public void UpdateStatus(TicketStatus newStatus)
        {
            Status = newStatus;
            LogComment("Status changed to " + newStatus);

            if (newStatus == TicketStatus.Closed)
            {
                CloseDate = DateTime.Now;
            }
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
