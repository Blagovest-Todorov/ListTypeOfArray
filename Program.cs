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

            Console.WriteLine("Reversed : ");
            int length = 12;
            int[] arr = Enumerable.Range(2, length).ToArray(); //this is->Row (2,3,4,5,6,7,8,9,10,11,12,13) 
                                                               //index:       (0,1,2,3,4,5,6,7, 8, 9,10,11 //for 12 elements

            for (int i = length - 1; i >= 0; i--)
            {
                int number = arr[i];
                Console.WriteLine(number);
            }
        }
    }
}
