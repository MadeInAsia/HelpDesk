using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;
using static HelpDesk.Ticket;
using System.Windows.Forms;

namespace HelpDesk
{
    public class TicketController
    {
        private List<Ticket> tickets = new List<Ticket>();

        public void CreateTicket(string name, string surname, string email, Ticket.TicketPriority priority,
            Ticket.TicketType type, Ticket.TicketStatus status, string topic, string reference, string details)
        {
            Contact person = new Contact(name, surname, email);
            Ticket newTicket = new Ticket(person, priority, type, status, topic, reference, details);
            AddTicket(newTicket);
        }
        public void AddTicket(Ticket ticket)
        {
            tickets.Add(ticket);
            SaveTicketsFile();
        }

        public void RemoveTicket(Ticket ticket)
        {
            tickets.Remove(ticket);
        }

        public void UpdateTicket(Ticket ticket)
        {
            // Update ticket
        }
        public void SaveTicketsFile()
        {
            string filePath =  "tickets.xml";

            XDocument doc = new XDocument(
                   new XElement("Tickets", tickets.ConvertAll(ticket =>
                       new XElement("Ticket",
                           new XElement("TicketID", ticket.TicketID),
                           new XElement("Contact",
                               new XElement("Name", ticket.Person.Name),
                               new XElement("Nachname", ticket.Person.Nachname),
                               new XElement("Email", ticket.Person.Email)),

                           new XElement("Priority", ticket.Priority.ToString()),
                           new XElement("Type", ticket.Type.ToString()),
                           new XElement("Topic", ticket.Topic),
                           new XElement("Reference", ticket.Reference),
                           new XElement("Details", ticket.Details),
                           new XElement("Status", ticket.Status.ToString()),
                           new XElement("OpenDate", ticket.OpenDate),
                           new XElement("CloseDate", ticket.CloseDate?.ToString() ?? ""),
                           new XElement("AssignedWorker", ticket.AssignedWorker)
                       )
                   ))
               );
            doc.Save(filePath);

            // Confirm save location
            MessageBox.Show($"Tickets saved successfully to: {filePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void LoadTicketsFile()
        {
             string filePath = "tickets.xml";

            if (!File.Exists(filePath)) // if doesnt exist create new file
            {
                XDocument newDoc = new XDocument(new XElement("Tickets"));
                newDoc.Save(filePath);
                return;
            }
            XDocument doc = XDocument.Load(filePath);
            foreach (XElement element in doc.Element("Tickets").Elements("Ticket"))
            {
                Ticket ticket = CreateTicketFromXML(element);
                tickets.Add(ticket);
            }
        }

        private Ticket CreateTicketFromXML(XElement element)
        {
            Contact person = ContactFromXML(element.Element("Contact"));
            if (person == null)
            {
                person = new Contact("Unknown", "Unknown", "unknown@unknown.com"); // Assign default 
             }
            Employee assignedWorker = AssignedWorkerFromXML(element.Element("AssignedWorker"));
            DateTime? closeDate = CloseDateFromXML(element.Element("CloseDate"));

            Ticket ticket = new Ticket(
                person,
                (TicketPriority)Enum.Parse(typeof(TicketPriority), element.Element("Priority").Value),
                (TicketType)Enum.Parse(typeof(TicketType), element.Element("Type").Value),
                (TicketStatus)Enum.Parse(typeof(TicketStatus), element.Element("Status").Value),
                element.Element("Topic").Value,
                element.Element("Reference").Value,
                element.Element("Details").Value
            )
            {
                TicketID = element.Element("TicketID").Value,
                OpenDate = DateTime.Parse(element.Element("OpenDate").Value),
                CloseDate = closeDate,
                AssignedWorker = assignedWorker
            };

            return ticket;
        }
        private Contact ContactFromXML(XElement personElement)
        {
            Contact person = null;

            if (personElement != null)
            {
                string name = "";
                string nachname = "";
                string email = "";

                XElement nameElement = personElement.Element("Name");
                XElement nachnameElement = personElement.Element("Nachname");
                XElement emailElement = personElement.Element("Email");

                if (nameElement != null) name = nameElement.Value;
                if (nachnameElement != null) nachname = nachnameElement.Value;
                if (emailElement != null) email = emailElement.Value;

                person = new Contact(name, nachname, email);
            }

            return person;
        }
        private Employee AssignedWorkerFromXML(XElement assignedWorkerElement)
        {
            if (assignedWorkerElement == null || assignedWorkerElement.Element("Employee") == null)
                return null; 

            XElement employeeElement = assignedWorkerElement.Element("Employee");
            return new Employee(
                int.Parse(employeeElement.Element("ID").Value),
                employeeElement.Element("Name").Value,
                employeeElement.Element("Nachname").Value,
                employeeElement.Element("Department").Value
            );
        }
        private DateTime? CloseDateFromXML(XElement closeDateElement)
        {
            DateTime? closeDate = null;

            if (closeDateElement != null) // Check if exists
            {
                string value = closeDateElement.Value;

                if (!string.IsNullOrEmpty(value)) // Make sure it's not empty
                {
                    closeDate = DateTime.Parse(value);
                }
            }
            return closeDate;
        }

        public List<Ticket> GetTickets()
        {
            return tickets;
        }

        public List<Ticket> GetTicketsByType(Ticket.TicketType type)
        {
            return tickets.Where(ticket => ticket.Type == type).ToList();
        }

        public List<Ticket> GetTicketsByStatus(Ticket.TicketStatus status)
        {
            return tickets.Where(ticket => ticket.Status == status).ToList();
        }

        public List<Ticket> GetTicketsByPriority(Ticket.TicketPriority priority)
        {
            return tickets.Where(ticket => ticket.Priority == priority).ToList();
        }
        public List<Ticket> GetTicketsByContact(string contactEmail)
        {
            return tickets.Where(ticket => ticket.Person.Email == contactEmail).ToList();
        }


    }
}
