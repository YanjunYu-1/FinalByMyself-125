using FinalByMyself.Models;

namespace FinalByMyself.Data.DAL
{
    public class AppUserDAL:IDAL<AppUser>
    {
        public ApplicationDbContext Context { get; set; }
    }
}
