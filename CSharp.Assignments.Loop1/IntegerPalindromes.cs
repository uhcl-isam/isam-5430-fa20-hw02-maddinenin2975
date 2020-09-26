using System;
namespace CSharp.Assignments.Loop1
{
    
    public class IntegerPalindromes
    {
        public static void Main()
        {
            // enter sentinel inputs
            // then check the palindrome only once.
            while (true)
            {
                //Console.WriteLine("Enter a number");

                String input = Console.ReadLine();
                if (input == null)
                {

                    break;
                }
                int i = Convert.ToInt32(input);

                int j, k, num, rem, sum;
                k = i;
                j = 0;
                num = i;
                sum = 0;
                // Console.WriteLine("Step1");
                while (k > 0)
                {
                    // Console.WriteLine("Step2");
                    k = k / 10;
                    j++;
                }
                if (j != 9)
                {
                    Console.WriteLine("Enter a palindrome");
                }
                else
                {
                    while (num > 0)
                    {
                        rem = num % 10; //for getting remainder by dividing with 10    
                        num = num / 10; //for getting quotient by dividing with 10    
                        sum = sum * 10 + rem;
                    }
                    if (sum == i)
                        Console.WriteLine("It is a palindrome number");
                    else
                    {
                        Console.WriteLine("It is not a Palindrome number");
                    }
                }

            }



        }
    }
}