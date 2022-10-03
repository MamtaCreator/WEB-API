using Assignment_3Lib.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace Assignment_3Lib.Repository
{
    public interface IContactsRepo
    {
        Task<int> AddContacts(Contact cn);
        Task updateContact(Contact cn);
        Task<int> DeleteContact(int id);
        Task<List<Contact>> GetContactsByCity(string city);
        Task<List<Contact>> GetAllContacts();
    }
}
