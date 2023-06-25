using LearningPlatform.Model;
using LearningPlatform.View;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPlatform.Controller
{
    public class AdminManager
    {
        private readonly LearningPlatform.Model.LearningPlatformDbContext _context;
        private readonly Encrypt encrypt = new Encrypt();
        //singlton start
        public static AdminManager instance { get => AdminManagerCreate.instance; }
        private AdminManager()
        {
            _context = new LearningPlatform.Model.LearningPlatformDbContext();
        }
        private class AdminManagerCreate
        {
            static AdminManagerCreate() { }
            internal static readonly AdminManager instance = new AdminManager();
        }
        //singlton end

        public async Task <bool> AddUser(Model.User receivedUser)
        {
            var user = await _context.ApplicationUsers.Where
                (u => u.Login == receivedUser.Login 
                || u.PersonalData.Email == receivedUser.PersonalData.Email 
                || u.PersonalData.PhoneNumber == receivedUser.PersonalData.PhoneNumber).FirstOrDefaultAsync();
            if(user!=null)
            {
                return false;
            }
            receivedUser.Salt = Guid.NewGuid().ToString();
            receivedUser.Password = await encrypt.HashPassword(receivedUser.Password, receivedUser.Salt);
            _context.ApplicationUsers.Add(receivedUser);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task ChangeUser(User changedUser)
        {
            var user = await _context.ApplicationUsers.Include(x => x.PersonalData).Where(x => x.Login == changedUser.Login).FirstOrDefaultAsync();
            user.PersonalData.FirstName = changedUser.PersonalData.FirstName;
            user.PersonalData.SecondName = changedUser.PersonalData.SecondName;
            user.PersonalData.PhoneNumber = changedUser.PersonalData.SecondName;
            user.PersonalData.Email = changedUser.PersonalData.Email;
            await _context.SaveChangesAsync();
        }
        public async Task RemoveUser(User changedUser)
        {
            var user = await _context.ApplicationUsers.Include(x => x.PersonalData).Where(x => x.Login == changedUser.Login).FirstOrDefaultAsync();
            _context.ApplicationUsers.Remove(user);
            _context.UserDatas.Remove(user.PersonalData);
            await _context.SaveChangesAsync();
        }
        public async Task <bool> AddEducationalVideo(EducationalVideo receiedEducationalVideo)
        {
            var educationalVideo = await _context.EducationalVideos.Where
                (e => e.Subject == receiedEducationalVideo.Subject && e.Name == receiedEducationalVideo.Name).FirstOrDefaultAsync();
            if(educationalVideo!=null)
            {
                return false;
            }
            _context.EducationalVideos.Add(receiedEducationalVideo);
            await _context.SaveChangesAsync();
            return true;
        }
        
    }
}
