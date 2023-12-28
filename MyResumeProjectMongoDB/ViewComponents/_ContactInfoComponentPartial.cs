using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using MyResumeProjectMongoDB.DAL.Entities;
using MyResumeProjectMongoDB.DAL.Settings;

namespace MyResumeProjectMongoDB.ViewComponents
{
    public class _ContactInfoComponentPartial:ViewComponent
    {
        private readonly IMongoCollection<ContactInfo> _contactinfoCollection;
        public _ContactInfoComponentPartial(IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _contactinfoCollection = database.GetCollection<ContactInfo>(_databaseSettings.ContactInfoCollectionName);

        }
        public IViewComponentResult Invoke()
        {
            var values = _contactinfoCollection.Find(x => true).ToList();
            return View(values);
        }
    }
}
