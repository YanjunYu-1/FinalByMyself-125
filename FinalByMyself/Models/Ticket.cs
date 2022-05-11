namespace FinalByMyself.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public int ProjectId { get; set; }

        //Q1 此处是否需要添加many to one的关系，类型是否应该是int，队友写的是string

        //Tickets与TicketTypes,TicketPriorties，TicketStatus  many to one
        public int TicketTypeId { get; set; }
        public TicketTypes TicketTypes { get; set; }
        public int TicketPriorityId { get; set; }//优先级
        public TicketPriorties TicketPriorties { get; set; }
        public int TicketStatusId { get; set; }//状态
        public TicketStatus TicketStatus { get; set; }
        //Q1 为什么有的是int有的是string=>UserId需要手动编写，前面会添加部门等信息例如XSK001（销售科001）

        //Tickets与AppUser  many to one
        public string OwnerUserId { get; set; }//所有者
        public AppUser OwnerUser { get; set; }
        public string AssignedToUserId { get; set; }//分配给用户
        public AppUser AssignedToUser { get; set; }


        //Tickets与TicketAttachments,TicketComments,TicketHistory,TicketNotifications  one to many
        public ICollection<TicketAttachment> TicketAttachments { get; set; }
        public ICollection<TicketComment> TicketComments { get; set; }
        public ICollection<TicketHistory> TicketHistories { get; set; }
        public ICollection<TicketNotification> TicketNotifications { get; set; }
        public Ticket()
        {
            ;//对于每一个one to many建立联系后需要new
            TicketAttachments = new HashSet<TicketAttachment>();
            TicketComments = new HashSet<TicketComment>();
            TicketHistories = new HashSet<TicketHistory>();
            TicketNotifications = new HashSet<TicketNotification>();

        }
    }
    public enum TicketStatus
    {
        Submitted,//提交，
        Asssigned,//已分配，
        Progressing,//进行中
        Resorved//保留
    }
    public enum TicketPriorties
    {
        High,//高
        Medium,//中
        Low//低
    }
    public enum TicketTypes
    {
        GeneralQuestion,//一般问题，
        BugReport,//错误报告，
        PaymentIssue,//付款问题，
        TechIssue,//技术问题，
        AccountIssue//帐户问题
    }
}
