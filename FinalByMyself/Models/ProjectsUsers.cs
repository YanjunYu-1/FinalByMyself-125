namespace FinalByMyself.Models
{
    public class ProjectsUsers
    {
        public int Id { get; set; }

        //ProjectsUsers与AppUser   many to one
        public string UserId { get; set; }
        public AppUser AppUser { get; set; }

        //ProjectsUsers与Projects   many to one
        public int ProjectId { get; set; }
        public Projects Projects { get; set; }
    }
}
