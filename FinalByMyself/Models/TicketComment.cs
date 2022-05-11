namespace FinalByMyself.Models
{
    public class TicketComment
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public DateTime Created { get; set; }

        //TicketComments与AppUser  many to one
        public string UserId { get; set; }
        public AppUser? User { get; set; }

        //TicketComments与Tickets  many to one
        public int TicketId { get; set; }
        public Ticket? Ticket { get; set; }


    }
}
