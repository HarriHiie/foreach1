using System.Collections.Generic;
using System;

namespace Foreach4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            
            var parts = new List<Person>()
            {
                new Person()
                { 
                    
                    Id = 1,
                    Human = "Anton Tammsaare"
                },
                new Person()
                {
                    Id = 2,
                    Human = "Lydia Koidula"
                },
                new Person()
                {
                    Id = 3,
                    Human = "August Gailit"
                },
                new Person()
                {
                    Id = 4,
                    Human = "Betti Alver"
                }
            };
            
            foreach (var part in parts)
            {
                Console.WriteLine("{0} {1}",
                    part.Id, part.Human);
            }
        }
    }

   
    public class Person
    {
        public int Id { get; set; }
        public string Human { get; set; }
    }
}