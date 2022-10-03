using System;
using System.Collections.Generic;
using System.Text;

namespace ContactsLib
{
   public interface IContactRepo
    {
        void  AddContact(Contact c);
        List<Contact> GetContact();
        void UpdateContact(Contact c,int id);
        void DeleteContact(int contactid);
        List<Contact> GetContactsByCity(string city);
    }
}
