using ContactManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program


{
    static void Main()
    {
        ContactHandler manager = new ContactHandler();

        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\n Välj ett alternativ:");
            Console.WriteLine("1. Lägg till kontakt");
            Console.WriteLine("2. Ta bort en kontakt");
            Console.WriteLine("3. Visa alla kontakter");
            Console.WriteLine("4. Sök efter en kontakt");
            Console.WriteLine("5. Uppdatera en kontakt");
            Console.WriteLine("6. Avsluta");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Ange namn :");
                    string name = Console.ReadLine();

                    Console.Write("Ange telefonnummer :");
                    string phoneNumber = Console.ReadLine();

                    Console.Write("Ange email : ");
                    string email = Console.ReadLine();

                    Contact newContact = new Contact(name, phoneNumber, email);
                    manager.AddContact(newContact);
                    
                    break;

                case "2":
                    Console.Write("Ange namn eller telefonnummer för att ta bort kontakten :");
                    string searchTerm = Console.ReadLine();
                    manager.RemoveContact(searchTerm);

                    break;

                case "3":
                    manager.ShowContacts();

                    break;

                case "4":
                    Console.Write("Ange namn eller telefonnummer att söka efter :");
                    
                    string searchTermToSearch = Console.ReadLine();

                    manager.SearchContact(searchTermToSearch);

                    break;

                case "5":
                    Console.Write("Ange namn eller nummer på kontakten du vill uppdatera : ");
                    string searcTermToUpdate = Console.ReadLine();
                    manager.UpdateContact(searcTermToUpdate);

                    break;

                case "6":

                    exit = true;
                    break;

                default:
                    Console.WriteLine("Ogiltligt svar. försök igen");

                    break;



            }
        }

    }
}
