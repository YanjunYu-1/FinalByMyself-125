namespace FinalByMyself.Models
{
    public class TicketNotifications//通知
    {
        public int Id { get; set; }

        //TicketNotifications与AppUser  many to one
        public string UserId { get; set; }
        public AppUser User { get; set; }

        //TicketNotifications与Tickets  many to one
        public int TicketId { get; set; }
        public Tickets Tickets { get; set; }
    }
}
