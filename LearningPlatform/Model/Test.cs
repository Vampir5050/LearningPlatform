using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPlatform.Model
{
    public class Test
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public Test()
        {
            Questions = new List<Question>();
        }
    }
}
