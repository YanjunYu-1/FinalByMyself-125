namespace FinalByMyself.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Projects与ProjectsUsers  one to many
        public ICollection<ProjectsUser> ProjectsUsers { get; set; }
        public Project()
        {
            ProjectsUsers = new List<ProjectsUser>();
        }
    }
}
