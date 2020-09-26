using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Assignments.Loop1
{
    public class PositiveInts
    {
       
        public static void Main()
        {
            Console.Error.WriteLine("Enter the value of n");

            int n = int.Parse(Console.ReadLine());
            int i = 1;

           
            while (i <= n)
            {
                Console.WriteLine(i);
                i++;
            }

        }
    }
}