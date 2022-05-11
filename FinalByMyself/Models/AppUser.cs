using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalByMyself.Models
{
    public class AppUser:IdentityUser
    {
        public ICollection<TicketAttachment> TicketAttachments { get; set; }
        public ICollection<TicketComment> TicketComments { get; set; }
        public ICollection<TicketHistory> TicketHistory { get; set; }
        public ICollection<TicketNotification> TicketNotifications { get; set; }

        [InverseProperty("OwnerUserId")]//两个类中存在两种联系，一般是用户有级别，例如，经理，主管，员工
        public ICollection<Ticket> OwnerUserId { get; set; }

        [InverseProperty("AssignedToUserId")]
        public ICollection<Ticket> AssignedToUserId { get; set; }
        public ICollection<ProjectsUser> ProjectsUsers { get; set; }

        public AppUser()
        {
            TicketAttachments = new HashSet<TicketAttachment>();
            TicketComments = new HashSet<TicketComment>();
            TicketHistory = new HashSet<TicketHistory>();
            TicketNotifications = new HashSet<TicketNotification>();
            OwnerUserId=new HashSet<Ticket>();
            AssignedToUserId=new HashSet<Ticket>();
            ProjectsUsers=new HashSet<ProjectsUser>();
        }
    }
}
