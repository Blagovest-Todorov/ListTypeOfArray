using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;

namespace _01.arrayExamplesTasks
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbersList = new List<int>
            {
              1, 2 , 3 , 4 , 5 , 6 , 7
            };
            Console.WriteLine("Count {0} : ", numbersList.Count);
            Console.WriteLine(string.Join(", ", numbersList));

            numbersList.Insert(5, 10);
            Console.WriteLine("Count {0}: ", numbersList.Count);
            Console.WriteLine(string.Join(", ", numbersList));

            numbersList.Add(1);
            Console.WriteLine("Count {0}: ", numbersList.Count);
            Console.WriteLine(string.Join(", ", numbersList));


            // numbersList.Add(1);
            numbersList.Remove(1); //removes a curent valueElement, the first element with a given value;
            numbersList.RemoveAt(1);
            Console.WriteLine("Count {0} : ", numbersList.Count);
            Console.WriteLine(string.Join(", ", numbersList));
        }
    }
}
