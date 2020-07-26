using System;

namespace LearningNullCond
{
    class Program
    {
        class Person
        {
            public string Name { get; set; }
        }

        static void Main(string[] args)
        {
            //When you need to deal with Nulls inside of properties
            //Great way to clean up code

            //Person person= null; new Person()  { Name = "Tim" };//what if this was null
            //null reference exception if not instantiated
            Person person = new Person();  //{ Name = "Tim" };//what if this was null

            //manual null check 
            if (person != null)
            //Console.WriteLine(person?.Name.Length);
            
            //if not instantiated, use null conditional operator '?' on name to rid of it
            //Console.WriteLine(person?.Name?.Length);

            //null coalescing with null conditional operators
            //we can set a default value to 'not set'
            Console.WriteLine(person?.Name?? "Not Set");
            //instead of empty line, you'll see 'not set'


            //up next, finish code for tomorrow
        }
    }
}
