using System.Data.Entity;

namespace MVCFriend.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<MVCFriend.Models.MatiasTorricoFriend> MatiasTorricoFriends { get; set; }
    }
}