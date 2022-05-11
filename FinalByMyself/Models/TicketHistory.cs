namespace FinalByMyself.Models
{
    public class TicketHistory
    {
        public int Id { get; set; }
        public string Property { get; set; }//属性，特性
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public DateTime Changed { get; set; }

        //TicketHistory与AppUser  many to one
        public string UserId { get; set; }
        public AppUser User { get; set; }

        //TicketHistory与Tickets  many to one
        public int TicketId { get; set; }
        public Ticket Ticket { get; set; }

    }
}
