using Assignment_3Lib.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment_3Lib.Repository
{
    public class ContactRepository : IContactsRepo
    {
        private contactDBContext _context;

        public ContactRepository(contactDBContext context)
        {
            _context = context;
        }
        public async Task<int> AddContacts(Contact cn)
        {
            if(_context!=null)
            {
                _context.Contacts.Add(cn);
                await _context.SaveChangesAsync();
                return cn.ContactId;
            }
            return cn.ContactId;
        }

        public async Task<int> DeleteContact(int id)
        {
            var contactToDelete = _context.Contacts.FirstOrDefaultAsync(c => c.ContactId == id);
            if(contactToDelete!=null)
            {
                _context.Remove(contactToDelete);
                await _context.SaveChangesAsync();
            }
            return id;

        }

        public async Task<List<Contact>> GetAllContacts()
        {
            if(_context!=null)
            {
                return await _context.Contacts.ToListAsync();
            }
            return null;


        }

        public async Task<List<Contact>> GetContactsByCity(string city)
        {
            var City = _context.Contacts.Where(c => c.City == city);
            if (City != null)
            {
                return await City.ToListAsync();
            }
            return null;
        }

        public async Task updateContact(Contact cn)
        {
            if (_context != null)
            {
                _context.Contacts.Update(cn);
                await _context.SaveChangesAsync();
                
            }
           
        }
    }
}
