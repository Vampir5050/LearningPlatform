using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPlatform.Model
{
    public class Question
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Answers { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }
}
