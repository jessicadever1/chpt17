using System;
using System.Collections.Generic;

namespace chpt17
{
    public class AddressBook
    {
        // create public prop called contacts whose value type is Dictionary, Keys are strings, values are Contact instances
        Dictionary<string, Contact> Contacts = new Dictionary<string, Contact>();

        public void AddContact(Contact contactObject)
        {
            try
            {
                Contacts.Add(contactObject.Email, contactObject);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Error: Contact was already added;");
            }

        }
        public Contact GetByEmail(string emailObject)
        {
            try
            {
                return Contacts[emailObject];
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("Email Address was not found");
                return null;
            }

        }
    }
}
