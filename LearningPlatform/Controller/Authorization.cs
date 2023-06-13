using LearningPlatform.Model;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LearningPlatform.Controller
{


    public class Authorization
    {

        private readonly LearningPlatform.Model.LearningPlatformDbContext _context;
        private readonly Encrypt encrypt = new Encrypt();
        //singlton start
        public static Authorization instance { get => AuthorizationCreate.instance; }
        private Authorization()
        {
            _context = new LearningPlatform.Model.LearningPlatformDbContext();
        }
        private class AuthorizationCreate
        {
            static AuthorizationCreate() { }
            internal static readonly Authorization instance = new Authorization();
        }
        //singlton end

        public async Task<Model.User> GetUser(string login, string password)
        {
           var user = await _context.ApplicationUsers.Include(u=>u.PersonalData).FirstOrDefaultAsync(u => u.Login == login);
            if (user == null)
            {
                return null;
            }
            else
            {
                user.Password = await encrypt.HashPassword(password, user.Salt);
                return user;
            }
        }
        
    }
}
