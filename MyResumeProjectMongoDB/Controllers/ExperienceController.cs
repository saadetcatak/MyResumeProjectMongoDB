using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using MyResumeProjectMongoDB.DAL.Entities;
using MyResumeProjectMongoDB.DAL.Settings;

namespace MyResumeProjectMongoDB.Controllers
{
    public class ExperienceController : Controller
    {
        private readonly IMongoCollection<Experience> _experienceCollection;
        public ExperienceController(IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _experienceCollection = database.GetCollection<Experience>(_databaseSettings.ExperienceCollectionName);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
