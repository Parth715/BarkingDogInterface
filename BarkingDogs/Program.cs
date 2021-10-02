using System;
using System.Collections.Generic;

namespace BarkingDogs
{
    class Program
    {
        static void Main(string[] args)
        {
            var dogs = new List<IBark>()
            {
                new Collie(),
                new Boxer(),
                new Chihuahua()
            };
            foreach(var dog in dogs)
            {
                Console.WriteLine($"The dog {dog.Name} barks {dog.Bark()}");
                var chawawa = dog as Chihuahua;
                if(chawawa != null)
                {
                    Console.WriteLine($"Walking chawawa {chawawa.Walk()}");
                }
            }
        }
    }
}
