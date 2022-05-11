using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalByMyself.Models
{
    public class AppUser:IdentityUser
    {
        public ICollection<TicketAttachments> TicketAttachments { get; set; }
        public ICollection<TicketComments> TicketComments { get; set; }
        public ICollection<TicketHistory> TicketHistory { get; set; }
        public ICollection<TicketNotifications> TicketNotifications { get; set; }

        [InverseProperty("OwnerUserId")]
        public ICollection<Tickets> OwnerUserId { get; set; }

        [InverseProperty("AssignedToUserId")]
        public ICollection<Tickets> AssignedToUserId { get; set; }
        public ICollection<ProjectsUsers> ProjectsUsers { get; set; }

        public AppUser()
        {
            TicketAttachments = new HashSet<TicketAttachments>();
            TicketComments = new HashSet<TicketComments>();
            TicketHistory = new HashSet<TicketHistory>();
            TicketNotifications = new HashSet<TicketNotifications>();
            OwnerUserId=new HashSet<Tickets>();
            AssignedToUserId=new HashSet<Tickets>();
            ProjectsUsers=new HashSet<ProjectsUsers>();
        }
    }
}
