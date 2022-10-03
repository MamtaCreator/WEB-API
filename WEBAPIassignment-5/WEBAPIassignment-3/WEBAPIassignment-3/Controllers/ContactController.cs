using Assignment_3Lib.Models;
using Assignment_3Lib.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WEBAPIassignment_3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ContactController : ControllerBase
    {
        private IContactsRepo repository;
        public ContactController(IContactsRepo _repository)
        {
            repository = _repository;
        }



        [HttpPost]
        public async Task addContact(Contact contact)
        {
           await repository.AddContacts(contact);
        }
        [HttpGet]
        //public async Task GetContacts()
        //{
        //   await  repository.GetAllContacts();
        //}
        //[HttpGet("{city}")]
        //public async Task GetContactByCity(string city)
        //{
        //    await repository.GetContactsByCity(city);
        //}


        public async Task<IActionResult> Get()
        {
            try
            {
                var contacts = await repository.GetAllContacts();
                if (contacts == null)
                    return NotFound();
                return Ok(contacts);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
        [HttpGet("{city}")]
        public async Task<IActionResult> Get(string city)
        {
            try
            {
                var contacts = await repository.GetContactsByCity(city);
                if (contacts == null)
                    return NotFound();
                return Ok(contacts);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPut]
        public async Task UpdateContact(Contact contact)
        {
            await repository.updateContact(contact);
        }
        [HttpDelete]
        public async Task DeleteContact(int id)
        {
            await repository.DeleteContact(id);
        }
    }
}
