using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Assignments.Loop1
{
    public class SquareUp
    {
      
        public static void Main()
        {
          
            Console.WriteLine("Enter number >= 0 : ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n >= 0)
            {
                int i = 0;
                while (i < n)
                {
                    int s = 0;
                    int x = 0;

                    int f = i * n;
                    while (f < (i + 1) * n)
                    {
                        if (s < n - i - 1)
                        {
                            Console.Write("0, ");

                            s++;
                        }
                        else
                        {

                            Console.Write((i + 1 - x) + ", ");

                            x++;
                        }
                        f++;
                    }
                    Console.WriteLine("");
                    i++;
                }
            }
            else
                Console.WriteLine("Wrong input Value given for n");

            Console.ReadLine();

        }
    }
}
