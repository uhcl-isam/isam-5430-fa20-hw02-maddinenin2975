using System;
public class FibonacciNumbers
{
    public static void Main(string[] args)
    {
        int x = 0, y = 1, z, i, number;
        Console.Write("Enter the number of elements: ");
        number = int.Parse(Console.ReadLine());
        Console.Write(x + " " + y + " "); //printing 0 and 1    
        for (i = 2; i < number; ++i) //loop starts from 2 because 0 and 1 are already printed    
        {
            z = x + y;
            Console.Write(z + " ");
            x = y;
            y = x;
        }
    }
}