using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPlatform.Model
{
    public class Article
    {
        public int ID { get; set; }
        public string Subject { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }

        public override string ToString()
        {
            return $"Предмет:  {Subject}      Название:  {Name}     ";
        }

    }
}
