using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Assignments.Loop1
{
    public class OddNumbers
    {
       

        public static void Main()
        {
            Console.Error.WriteLine("Enter the Start number");
            int startNumber = Convert.ToInt32(Console.ReadLine());
            Console.Error.WriteLine("Enter the End number");
            int endNumber = Convert.ToInt32(Console.ReadLine());

            if (startNumber < endNumber)
            {
                for (var i = startNumber; i <= endNumber; i++)
                {
                    if (Math.Abs(i) % 2 == 1)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                for (var i = endNumber; i <= startNumber; i++)
                {
                    if (Math.Abs(i) % 2 == 1)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            
        }
    }
}