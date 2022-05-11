namespace FinalByMyself.Models
{
    public class Projects
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Projects与ProjectsUsers  one to many
        public ICollection<ProjectsUsers> ProjectsUsers { get; set; }
        public Projects()
        {
            ProjectsUsers = new List<ProjectsUsers>();
        }
    }
}
