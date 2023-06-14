using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace LearningPlatform.Model
{

    public class LearningPlatformDbContext : DbContext
    {

        public  LearningPlatformDbContext():base("DefaultConnection")
        {
            
        }
      
        public DbSet<Event> Events { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<User> ApplicationUsers { get; set; }
        public DbSet<UserData> UserDatas { get; set; }
        public DbSet<Mark> Marks { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<EducationalVideo> EducationalVideos { get; set; }
    }

}
