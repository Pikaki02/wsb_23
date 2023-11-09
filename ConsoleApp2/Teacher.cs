using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Teacher : Person
    {
        public List<string> Subject { get; set; }
        public Teacher(string name, string surname, DateTime dateOfBirth, List<string> subject) : base(name,surname,dateOfBirth) 
        {
            Subject = subject;
        }    
    }
}
