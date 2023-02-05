using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3._4
{
     class Person
    {
        public Person(string name, string last_name, string email, DateTime birthday, int id)
        {
            First_Name = name;
            Last_Name = last_name;
            Email = email;
            Birhtday = birthday;
            Id = id;
        }

        public string First_Name { get; private set; }
        public string Last_Name { get; private set; }
        public string Email { get; private set; }
        public DateTime Birhtday { get; private set; }
        public int Id { get; private set; }
    }
}
