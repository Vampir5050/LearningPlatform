using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LearningPlatform.Model
{
    public class Group
    {
        public int ID { get; set; }
        public string GroupName { get; set; }
        public virtual  ICollection<User> Users { get; set; }
        public virtual ICollection<Test> Tests { get; set; }
        public Group()
        {
            Users = new List<User>();
            Tests = new List<Test>();
        }
    }
}
