using System.Data.Entity;

namespace APIFriend2.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<APIFriend2.Models.MatiasTorricoFriend> MatiasTorricoFriends { get; set; }
    }
}