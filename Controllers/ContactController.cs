using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Exercice_1.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact/AllContacts
        public IActionResult AllContacts()
        {
            return View();
        }

        // GET: Contact/Contact
        public IActionResult Contact()
        {
            return View();
        }

        // GET: Contact/Contact/CreateContact
        public IActionResult CreateContact()
        {
            return View();
        }

        }
}
