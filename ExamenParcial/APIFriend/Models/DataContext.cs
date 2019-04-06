using System.Data.Entity;

namespace APIFriend.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<APIFriend.Models.MatiasTorricoFriend> MatiasTorricoFriends { get; set; }
    }
}