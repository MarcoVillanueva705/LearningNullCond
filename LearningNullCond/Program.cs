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

            Person person= null; //new Person()  { Name = "Tim" };//what if this was null
            //manual null check 
            if(person != null)
            Console.WriteLine(person?.Name);
            //up next, finish code for tomorrow
        }
    }
}
