using System;

namespace IntermediaryClasses
{
     public class Program
    {
        static void Main(string[] args)
        {  
            //instance method
            /*var person = new Person();
            person.Name = "John";
            person.Introduce("Mosh");*/

            //Static method (acessible by the class not the object)
            var person = Person.Parse("John");
            person.Introduce("Mosh");
        }
    }
}
            
        