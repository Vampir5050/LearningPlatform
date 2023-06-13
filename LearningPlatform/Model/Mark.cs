using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPlatform.Model
{
    public class Mark
    {
        public int ID { get; set; }
        public Subject Subject { get; set; }
        public int Grade { get; set; }
        public string Comment { get; set; }
    }
}
