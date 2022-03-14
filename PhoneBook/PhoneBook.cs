﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Phonebook
    {
        private List<Contact> Contacts = new List<Contact>();
        public void Add(Contact newcontact)
        {
            Contacts.Add(newcontact);
            Console.WriteLine("Contact was Added");
        }
        private void DisplayContactDetails(Contact contact)
        {
            Console.WriteLine($"Contact: {contact.Name}-{contact.Number}");
        }
        public void DisplayContact(string number)
        {
            var contact = Contacts.FirstOrDefault(c => c.Number == number);
            if (contact == null)
                Console.WriteLine("Contact not found");
            else DisplayContactDetails(contact);
        }
        public void DisplayAllContacts()
        {
            foreach (var contact in Contacts)
                DisplayContactDetails(contact);
        }
        public void DisplayMatchingContacts(string searchphrase)
        {
            var Matchingcontacts = Contacts.Where(c => c.Name.Contains(searchphrase)).ToList();
            foreach (var contact in Matchingcontacts)
                DisplayContactDetails(contact);
        }
        public void DeleteContact(string number)
        {
            var contact = Contacts.Find(c => c.Number == number);
            if (contact == null)
                Console.WriteLine("There is no contact with this number");
            else
                Contacts.Remove(contact);
            Console.WriteLine("Contact was Deleted");
        }
    }
}