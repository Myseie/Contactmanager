using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    class Contact
    {
        public string Name { get; set; }

        public string Number { get; set; }

        public string Email { get; set; }


        public Contact(string name, string number, string email)
        {
            Name = name;

            Number = number;

            Email = email;

        }

        public override string ToString()
        {
            return $" Namn : {Name} Telefonnumer : {Number} Emailadress : {Email} ";

        }



    }
}
