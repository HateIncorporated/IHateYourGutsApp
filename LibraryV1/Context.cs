using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryV1
{
    public class Context : DbContext
    {
        public Context(): base("IHateYourGutsDB")
        {
            // Указывает EF, что если модель изменилась,
            // нужно воссоздать базу данных с новой структурой
           // Database.SetInitializer(
           //     new DropCreateDatabaseIfModelChanges<SampleContext>());

            Database.SetInitializer(new IHateYourGutsDBInitializer());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Question> Questions { get; set; }
    }
}
