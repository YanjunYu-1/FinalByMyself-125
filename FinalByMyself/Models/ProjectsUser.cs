namespace FinalByMyself.Models
{
    public class ProjectsUser
    {
        public int Id { get; set; }

        //ProjectsUsers与AppUser   many to one
        public string UserId { get; set; }
        public AppUser? User { get; set; }

        //ProjectsUsers与Projects   many to one
        public int ProjectId { get; set; }
        public Project? Project { get; set; }
    }
}
