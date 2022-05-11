namespace FinalByMyself.Models
{
    public class TicketComments
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public DateTime Created { get; set; }
        public int TicketId { get; set; }
        public int UserId { get; set; }

        //TicketComments与Tickets  many to one
        public int TicketsId { get; set; }
        public Tickets ticket { get; set; }


    }
}
