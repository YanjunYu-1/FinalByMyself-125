namespace FinalByMyself.Models
{
    public class TicketAttachment//跟踪的附件
    {
        public int Id { get; set; }
        public string FilePath { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }

        //TicketAttachments与AppUser  many to one
        public string UserId { get; set; }
        public AppUser? User { get; set; }

        //TicketAttachments与Tickets  many to one
        public int TicketsId { get; set; }
        public Ticket? ticket { get; set; }
        public string FileUrl { get; set; }
    }
}
