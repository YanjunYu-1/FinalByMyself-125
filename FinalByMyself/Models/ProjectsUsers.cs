namespace FinalByMyself.Models
{
    public class ProjectsUsers
    {
        public int Id { get; set; }
        public string UserId { get; set; }

        //ProjectsUsers与Projects   many to one
        public int ProjectId { get; set; }
        public Projects Projects { get; set; }
    }
}
