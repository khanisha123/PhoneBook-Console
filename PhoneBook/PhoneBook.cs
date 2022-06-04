using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class PhoneBook
    {
        private List<Contact> _contacts { get; set; } = new List<Contact>();
        private void DisplayContactDetail(Contact contact)
        {
            Console.WriteLine($"Contact : {contact.Name}, {contact.Number}");

        }
        private void DisplayContactDetail(List<Contact> contact)
        {
            foreach (var contact1 in contact)
            {
                DisplayContactDetail(contact1);

            }

        }
        public void AddContact(Contact contact)
        {
            _contacts.Add(contact);
        }
        public void DisplayContact(string number)
        {
            var contact = _contacts.FirstOrDefault(c => c.Number == number);
            if (contact == null)
            {
                Console.WriteLine("Contact not found");
            }
            else
            {
                DisplayContactDetail(contact);
            }
        }
        public void DisplayAllContact()
        {
            DisplayContactDetail(_contacts);
        }
        public void DisplayAllMatchingContact(string seacrhPhrase)
        {
            var searchContact = _contacts.Where(c => c.Name.ToLower().Contains(seacrhPhrase.Trim().ToLower())).ToList();
            DisplayContactDetail(searchContact);
        }
    }
}
