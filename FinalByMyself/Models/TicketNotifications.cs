namespace FinalByMyself.Models
{
    public class TicketNotifications//通知
    {
        public int Id { get; set; }
        public string UserId { get; set; }

        //TicketNotifications与Tickets  many to one
        public int TicketId { get; set; }
        public Tickets Tickets { get; set; }
    }
}
