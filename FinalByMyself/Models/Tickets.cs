namespace FinalByMyself.Models
{
    public class Tickets
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public int ProjectId { get; set; }
        public int TicketTypeId { get; set; }
        public int TicketPriorityId { get; set; }//优先级
        //Q1 为什么有的是int有的是string=>UserId需要手动编写，前面会添加部门等信息例如XSK001（销售科001）
        public int TicketStatusId { get; set; }//状态
        public string OwnerUserId { get; set; }//所有者
        public string AssignedToUserId { get; set; }//分配给用户

        //Tickets与TicketAttachments,TicketComments,TicketHistory,TicketNotifications  one to many
        public ICollection<TicketAttachments> TicketAttachments { get; set; }
        public ICollection<TicketComments> TicketComments { get; set; }
        public ICollection<TicketHistory> TicketHistories { get; set; }
        public ICollection<TicketNotifications> TicketNotifications { get; set; }
        public Tickets()
        {
            ;//对于每一个one to many建立联系后需要new
            TicketAttachments = new HashSet<TicketAttachments>();
            TicketComments = new HashSet<TicketComments>();
            TicketHistories = new HashSet<TicketHistory>();
            TicketNotifications = new HashSet<TicketNotifications>();

        }
    }
    public enum TicketStatus
    {

    }
    public enum TicketPriorties
    {

    }
    public enum TicketTypes
    {

    }
}
