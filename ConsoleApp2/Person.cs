using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DataOfBirth { get; set; }
        public Address Addres;

        public Person(string name, string surname, DateTime dateOfBirth) 
        {
            Name = name;
            Surname = surname;
            DataOfBirth = dateOfBirth;
        }
        public Person(string name, string surname, DateTime dateOfBirth, Address address) : this(name, surname, dateOfBirth) 
        { 
            this.Addres = address;
        }
        public string GetFullName(string name, string surname, DateTime dateOfBirth)
        {
            return name + " " + Surname + Age.ToString();
        }
        public int Age
        {
            get
            {
                TimeSpan diference = DateTime.Now - DataOfBirth;
                return (int)(diference.Days / 365.25);
            }
        }
    }
}
