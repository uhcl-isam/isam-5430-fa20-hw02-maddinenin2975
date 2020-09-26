using System;
namespace CSharp.Assignments.Loop1
{
   
    public class LargestNumbers
    {
        public static void Main()
        {
            // get first number and assign 

            int counter = 0;
            int number;
            int l1 = 0;
            int l2= 0;

            l1 = int.MinValue;

             
            while (counter < 10)
            {
                // prompt the user to enter integer values.
                Console.WriteLine("Enter an integer value");
                number = int.Parse(Console.ReadLine());
                counter++;

               

                if (number > l1)
                {
                    l2 = l1;
                    l1 = number;

                }

                else if (number > l2)
                {
                    l2 = number;
                }


            }
            Console.WriteLine($"The largest value is {l1}");
            Console.WriteLine($"The largest value is {l2}");


        }
    }
}