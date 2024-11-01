using Microsoft.AspNetCore.Mvc;
using Purple_Buzz.Data;
using Purple_Buzz.Models.Contact;
using Purple_Buzz.Models.Home;

namespace Purple_Buzz.Controllers
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
            var contactsList = new List<ContactVM>();

            foreach (var contact in contacts)
            {
                var contactVM = new ContactVM()
                {
                    Name = contact.Name,
                    Description = contact.Description,
                    Icon = contact.Icon,
                    Phone = contact.Phone
                };
                contactsList.Add(contactVM);
            }

            var viewModel = new ContactIndexVM
            {
                Contacts = contactsList
            };

            return View(viewModel);
        }
    }
}
