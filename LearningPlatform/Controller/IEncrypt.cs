using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPlatform.Controller
{
    public interface IEncrypt
    {
        Task<string> HashPassword(string password, string salt);
    }
}
