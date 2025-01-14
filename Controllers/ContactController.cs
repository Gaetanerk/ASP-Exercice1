using Exercice_1.Models;
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

        // GET: Contact/CreateContact
        public IActionResult CreateContact()
        {
            return View();
        }

        // GET: Contact/Liste
        public IActionResult ContactListe()
        {
            ViewBag.ContactListe = "Liste des contacts";
            var contactListe = new List<Contact>
                {
                    new Contact
                    {
                        Name = "Doe",
                        FirstName = "John",
                        DetailContact = new DetailContact
                        {
                            Id = 1,
                            Email = "john.doe@gmail.com"
                        }
                    },
                    new Contact
                    {
                        Name = "Gansa",
                        FirstName = "Eric",
                        DetailContact = new DetailContact
                        {
                            Id = 1,
                            Email = "eric.gansa@gmail.com"
                        }
                    },
                };
            ViewData["emails"] = "avec leurs emails";
            return View(contactListe);
        }
    }
}
