using System.Linq;

namespace Migrations
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var context = new UsersContext())
            {
                context.Users.ToList();
            }
        }
    }
}
