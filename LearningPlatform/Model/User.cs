using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPlatform.Model
{
   public enum RoleType
    {
        Admin,
        User,
        Teacher

    }
    public class User
    {
        public int ID { get; set; }
        public RoleType Role { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public Group Group { get; set; }
        public UserData PersonalData { get; set; }
        public virtual ICollection<Mark> Marks { get; set; }
        public User()
        {
            this.PersonalData = new UserData();
            this.Marks = new List<Mark>();
        }
        public override string ToString()
        {
            return $"{Login} - {PersonalData.FirstName} - {PersonalData.SecondName}";
        }
    }
}
