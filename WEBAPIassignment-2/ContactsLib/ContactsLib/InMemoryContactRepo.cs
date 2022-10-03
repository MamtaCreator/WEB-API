using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContactsLib
{
    
   
    public class InMemoryContactRepo : IContactRepo
    {
        static List<Contact> contactsList = null;
        public InMemoryContactRepo()
        {
            contactsList = new List<Contact>
            {
                new Contact{ContactId = 1001,ContactName = "Home" ,City = "Mumbai" ,CellNo = "9987200797"},
                new Contact{ContactId = 1001,ContactName = "Mamta" ,City = "Mumbai" ,CellNo = "9987200797"},
                new Contact{ContactId = 1002,ContactName = "Ketan" ,City = "Delhi" ,CellNo = "9988200797"},
                new Contact{ContactId = 1003,ContactName = "Ketan Soni" ,City = "Delhi" ,CellNo = "9988200797"}

            };
        }
        public void AddContact(Contact contacts)
        {
            contactsList.Add(contacts);
        }

        public void DeleteContact(int contactid)
        {
            var contactTodelete = contactsList.FirstOrDefault(c => c.ContactId == contactid);
            if(contactTodelete!=null)
            {
                contactsList.Remove(contactTodelete);
            }
           
        }

        public List<Contact> GetContact()
        {
            return contactsList;
        }

        public List<Contact> GetContactsByCity(string city)
        {
            var contacts = contactsList.Where(c => c.City == city).ToList();
            return contacts;
           
        }

        public void UpdateContact(Contact c,int id)
        {
            var contactToUpdate = contactsList.FirstOrDefault(c => c.ContactId == id);
            if(contactToUpdate!=null)
            {
                contactToUpdate.ContactName = c.ContactName;
                contactToUpdate.City = c.City;
                contactToUpdate.CellNo = c.CellNo;
            }
            
        }
    }
}
