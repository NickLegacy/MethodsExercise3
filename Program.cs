using System;
using System.Collections.Generic;

namespace StatementsLoopsEx3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a method that will print to the console all numbers 1000 through -1000.
            var numbers = new List<int>();

            var num = -1001;

            do
            {
                num++;

                numbers.Add(num);

            }
            while (num < 1000);

            {
                Console.WriteLine();
                Console.WriteLine("This is the list of numbers from -1000 to +1000");
            }

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            //Write a method that will print to the console numbers 3 through 999 by 3 each time.
            {
                Console.WriteLine();
                Console.WriteLine("This is the list of numbers from 3 to 999 by 3's");
            }

            for (int i = 3; i < 1000; i+=3)
            {
                Console.WriteLine(i);
            }
            //Write a method to accept two integers as parameters and check whether they are equal or not.
            {
                Console.WriteLine();
                Console.WriteLine("Method to check if two numbers are equal or not equal");
            }
            
            {
                int int1, int2;
                Console.WriteLine("Please enter 1st Number");
                int1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter 2nd Number");
                int2 = Convert.ToInt32(Console.ReadLine());
                {
                    Console.WriteLine();
                }
                if (int1 == int2)
                    Console.WriteLine($"{int1} and {int2} are equal");
                else
                    Console.WriteLine($"{int1} and {int2} are not equal");
            }
            //Write a method to check whether a given number is even or odd.
            int a;
            Console.WriteLine("Method to check whether a given number is even or odd.");
            Console.WriteLine("Please Enter a number");

            a = int.Parse(Console.ReadLine());

            if(a % 2 == 0)
            {
                Console.WriteLine();
                Console.WriteLine($"{a} is an even number");
            }
            else
            {
                Console.WriteLine($"{a} is an odd number");
            }
            //Write a method to check whether a given number is positive or negative.
            int b;
            Console.WriteLine("Method to check whether a given number is positive or negative.");
            Console.WriteLine("Please Enter a number");

            b = int.Parse(Console.ReadLine());

            if (b > 0)
            {
                Console.WriteLine();
                Console.WriteLine($"{b} is a positive number");
            }
            else
            {
                Console.WriteLine($"{b} is a negative number");
            }
            //Write a method to read the age of a candidate and determine whether they can vote.
            int age;
            Console.WriteLine("Method to read the age of a candidate and determine whether they can vote.");
            Console.WriteLine("Please Enter your age");

            age = int.Parse(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine();
                Console.WriteLine("You are old enough to vote");
            }
            else
            {
                Console.WriteLine("Im sorry. You are too young to vote");
            }
            //Write a method to check if an integer (from the user) is in the range -10 to 10.
            int x;
            Console.WriteLine("Method to check if an integer is in the range -10 to 10.");
            Console.WriteLine("Please Enter a number");

            x = int.Parse(Console.ReadLine());

            if (x > -11 && x < 11)
            {
                Console.WriteLine();
                Console.WriteLine("This number is in range");
            }
            else
            {
                Console.WriteLine("This number is out of range");
            }

            Console.WriteLine("Method to display a given integer's multiplication table");
            Console.WriteLine("Please Enter a number");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int aa;
            for (int z = 1; z <= 12; z++)
            {
                aa = y * z;
                Console.WriteLine(y + " x " + z + " = " + aa);

            }

        }


    }
}
