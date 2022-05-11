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
        public int TicketStatusId { get; set; }//状态
        public string OwnerUserId { get; set; }//所有者
        public string AssignedToUserId { get; set; }//分配给用户

        //Tickets与TicketAttachments  one to many
        public ICollection<TicketAttachments> TicketAttachments { get; set; }
        public Tickets()
        {
            ;//对于每一个one to many建立联系后需要new
            TicketAttachments =new HashSet<TicketAttachments>()
        }
    }
}
