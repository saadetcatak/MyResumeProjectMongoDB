using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using MyResumeProjectMongoDB.DAL.Entities;
using MyResumeProjectMongoDB.DAL.Settings;

namespace MyResumeProjectMongoDB.Controllers
{
    public class MessageController : Controller
    {
        private readonly IMongoCollection<Message> _messageCollection;
        public MessageController(IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _messageCollection = database.GetCollection<Message>(_databaseSettings.MessageCollectionName);

        }
        public async Task<IActionResult> Index()
        {
            var values = await _messageCollection.Find(x => true).ToListAsync();
            return View(values);
        }
    }
}
