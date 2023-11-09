﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Student : Person
    {
        public int StudentNumber {  get; set; }
        public Student(string name, string surname, DateTime dateOfBirth, int studentNumber) : base(name,surname, dateOfBirth)
        {
            StudentNumber = studentNumber;
        }
    }
}
