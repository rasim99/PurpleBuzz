using Microsoft.AspNetCore.Mvc;
using PB401PurpleBuzz.Data;
using PB401PurpleBuzz.Models.Contact;

namespace PB401PurpleBuzz.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;
        public ContactController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var contacts = _context.Contacts.ToList();
            var contactsList=new List<ContactVM>();
            foreach (var contact in contacts)
            {
                var contactVM = new ContactVM
                {
                    ContactTYpe = contact.ContactTYpe,
                    Icon = contact.Icon,
                    PhoneNumber = contact.PhoneNumber,
                    WorkerName = contact.WorkerName
                };
                contactsList.Add(contactVM);
            }
            var model=new ContactIndexVM { Contacts = contactsList };
            return View(model);
        }
    }
}
