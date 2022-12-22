using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//A class encapsulates data(stored in fields) and behavior(defined by methods).
namespace IntermediaryClasses
{
    public class Person
    {
        //Field
        public string Name;
        //Method
        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }
        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;
            return person;
        }
    }
}