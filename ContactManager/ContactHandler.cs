using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    class ContactHandler
    {
        private List<Contact> contacts = new List<Contact>();


        public void AddContact(Contact contact)
        {
            contacts.Add(contact);

            Console.WriteLine($"Kontakten : {contact.Name} har lagts till ");
        }

        public void RemoveContact(string searchTerm)
        {
            Contact contactToRemove = contacts.Find(c => c.Name.ToLower() == searchTerm.ToLower());
            if (contactToRemove != null)
            {
                contacts.Remove(contactToRemove);

                Console.WriteLine($"Kontakten : '{contactToRemove.Name}' har tagits bort");
            }
            else
            {
                Console.WriteLine($"Ingen kontakt med namnet eller telefonnummret '{searchTerm}' hittades");

            }
        }
        

        public void UpdateContact(string searchTerm)
        {
            Contact contactToUpdate = contacts.Find(c => c.Name.ToLower() == searchTerm.ToLower() );

            if (contactToUpdate != null)
            {
                Console.WriteLine($"Uppdaterar kontakt : {contactToUpdate}");

                Console.Write("Vill du uppdatera namnet? (ja/nej): ");
                string updateName = Console.ReadLine().ToLower();

                if (updateName == "ja")
                {
                    Console.Write("Ange nytt namn : ");
                    contactToUpdate.Name = Console.ReadLine();
                }

                Console.Write("Vill du uppdatera telefonnummret? (ja/nej) : ");
                string updatePhone = Console.ReadLine().ToLower();

                if (updatePhone == "ja")
                {
                    Console.Write("Ange nytt nummmer :");
                    contactToUpdate.Number = Console.ReadLine();

                }

                Console.Write("Vill du uppdatera emailen? (ja/nej) : ");
                string updateEmail = Console.ReadLine().ToLower();

                if(updateEmail == "ja")
                {
                    Console.Write("Ange ny Email : ");
                    contactToUpdate.Email = Console.ReadLine();

                }

                Console.WriteLine("Kontakten har uppdaterats");
            }
            else
            {
                Console.WriteLine($"Ingen kontakt med sökordet '{searchTerm}' hittades.");
            }

            
        }


        public void ShowContacts()
        {
            if (contacts.Count == 0)
            {
                Console.WriteLine("Inga kontakter hittades");
            }
            else
            {
                Console.WriteLine("Kontakter i listan :");
                foreach (Contact contact in contacts)
                {
                    Console.WriteLine(contact);
                }
            }
        }

        public void SearchContact(string searchTerm)
        {
            List<Contact> foundContacts = contacts.FindAll(c => c.Name.ToLower().Contains(searchTerm));

            if (foundContacts.Count > 0)
            {
                Console.WriteLine("Kontakter hittade: ");
                foreach (Contact contact in foundContacts)
                {
                    Console.WriteLine(contact);
                }
            }
            else
            {
                Console.WriteLine($"Inga kontakter med sökordet '{searchTerm}' hittades");
            }
        }
    }
}
