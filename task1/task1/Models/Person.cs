using System;
using System.Collections.Generic;
using System.Text;

namespace task1.Models
{
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public Person()
        {

        }
        public Person(string Name,string Surname,int Age)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Age = Age;
        }
    }
}
