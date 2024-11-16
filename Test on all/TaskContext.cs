using System.Data.Entity;

namespace Test_on_all
{
    public class TaskContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Task> Tasks { get; set; }
    }

    

   
}
