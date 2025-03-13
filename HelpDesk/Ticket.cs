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
        public List<String> Comments { get; private set; } 


        // for tickets from XML (avoids adding new comments)
        public Ticket(string ticketID, Contact person, TicketPriority priority, TicketType type, string topic, string reference, string details, TicketStatus status, DateTime openDate, DateTime? closeDate, Employee assignedWorker, List<string> comments)
        {
            TicketID = ticketID;
            Person = person;
            Priority = priority;
            Type = type;
            Topic = topic;
            Reference = reference;
            Details = details;
            Status = status;
            OpenDate = openDate;
            CloseDate = closeDate;
            AssignedWorker = assignedWorker;
            Comments = comments ?? new List<string>(); //  Use existing comments 
        }

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

            if (Comments.Count == 0)
                LogComment("Ticket created by " + person.Name + person.Nachname);

            // change this so that the listbox only shows the ticket instance once, not from user and admin at the same time only one and other or so 
        }

        public void AddComment(string author, string comment)
        {
            string timestamp = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
            Comments.Add($"{timestamp} - {author}: {comment}");
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

        private void LogComment(string message)
        {
            string timestamp = DateTime.Now.ToString();
            Comments.Add(timestamp + ": " + message);
        }

        public void AssignWorker(Employee employee)
        {
            if (AssignedWorker == null || AssignedWorker.ID != employee.ID)
            {
                AssignedWorker = employee;
                LogComment("Assigned to " + employee.Name + " " + employee.Nachname);
            }
        }
        public void UpdatePriority(TicketPriority newPriority)
        {
            if (Priority != newPriority)
            {
                Priority = newPriority;
                LogComment("Priority changed to" + newPriority + " on " + DateTime.Now);
            }
        }

        public void UpdateStatus(TicketStatus newStatus)
        {
            if (Status != newStatus)
            {
                Status = newStatus;
                LogComment("Status changed to " + newStatus);

                if (newStatus == TicketStatus.Closed)
                {
                    CloseDate = DateTime.Now;
                    LogComment("Ticket closed on " + CloseDate);
                }
            }
        }
    }
}
