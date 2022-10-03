using ContactsLib;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private IContactRepo contactRepo = null;
        public ContactsController(IContactRepo _contactRepo)
        {
            this.contactRepo = _contactRepo;
        }

        [HttpGet]
        public ActionResult<List<Contact>> getAllContacts()
        {
            return contactRepo.GetContact();
        }

        [HttpGet("{city}")]
        public ActionResult<List<Contact>> getAllContactByCity(string city)
        {
            return contactRepo.GetContactsByCity(city);
        }

        [HttpPost]
        public ActionResult<Contact> PostContact( [FromBody] Contact contact)
        {
            contactRepo.AddContact(contact);
            return contact;
        }

        [HttpPut("{id}")]
        public ActionResult<Contact> PutContact([FromBody] Contact contact,int id)
        {
            contactRepo.UpdateContact(contact,id);
            return contact;
        }

        [HttpDelete("{id}")]

        public ActionResult<int> DeleteContact(int id)
        {
            contactRepo.DeleteContact(id);
            return id;
        }




    }
}
