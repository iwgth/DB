using System;
using System.Collections.Generic;
using System.Text;

namespace winf
{
    class User
    {
        public string ID { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string patronymic { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string position { get; set; }
        public string departament { get; set; }
        public string salary { get; set; }
        public string avatar { get; set; }

        public User()
        {

        } 

        public override string ToString()
        {
            return "Name: " + name + " | Email: " + email;
        }

        public string stringToShowMainform()
        {
            return "Name: " + name + " | Surname: " + surname + " | Patronymic: " + patronymic + " | Phone: " + phone;
        }
    }
}
