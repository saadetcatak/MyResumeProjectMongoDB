using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using MyResumeProjectMongoDB.DAL.Entities;
using MyResumeProjectMongoDB.DAL.Settings;

namespace MyResumeProjectMongoDB.Controllers
{
    public class ContactInfoController : Controller
    {
        private readonly IMongoCollection<ContactInfo> _contactinfoCollection;

        public ContactInfoController(IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _contactinfoCollection = database.GetCollection<ContactInfo>(_databaseSettings.ContactInfoCollectionName);

        }

        public async Task<IActionResult> Index()
        {
            var values = await _contactinfoCollection.Find(x => true).ToListAsync();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateContactInfo()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateContactInfo(ContactInfo contactInfo)
        {
            await _contactinfoCollection.InsertOneAsync(contactInfo);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteContactInfo(string id)
        {
            await _contactinfoCollection.DeleteOneAsync(x => x.ContactInfoID == id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateContactInfo(string id)
        {
            var values = await _contactinfoCollection.Find(x => x.ContactInfoID == id).FirstOrDefaultAsync();
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateContactInfo(ContactInfo contactInfo)
        {
            await _contactinfoCollection.FindOneAndReplaceAsync(x => x.ContactInfoID == contactInfo.ContactInfoID, contactInfo);
            return RedirectToAction("Index");
        }
    }
}
