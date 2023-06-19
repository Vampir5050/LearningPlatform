using LearningPlatform.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPlatform.Controller
{
    public class DatabaseManagement
    {
        private readonly LearningPlatform.Model.LearningPlatformDbContext _context;
        //singlton start
        public static DatabaseManagement instance { get => DatabaseManagementCreate.instance; }
        private DatabaseManagement()
        {
            _context = new LearningPlatform.Model.LearningPlatformDbContext();
        }
        private class DatabaseManagementCreate
        {
            static DatabaseManagementCreate() { }
            internal static readonly DatabaseManagement instance = new DatabaseManagement();
        }
        //singlton end

        public async Task<List<EducationalVideo>> GetEducationalVideos()
        {
            return await _context.EducationalVideos.ToListAsync();
        }

        public async Task<List<Test>> GetTestsAsync()
        {
            return await _context.Tests.ToListAsync();
        }

        public void AddTestAsync(Test test)
        {
            _context.Tests.Add(test);
            _context.SaveChanges();
        }
    }
}
