using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsWithLoopsAndConditionals
{
    internal class Methods
    {
        public static void PrintNum()
        {
            Console.WriteLine("Here is an acending list of numbers from negative one-thounsand to one-thousand:");
            var num = -1000;
           do
            {
                Console.WriteLine(num);
                num++;
            } while (num < 1001);
        }

        public static void Printby3()
        {
            Console.WriteLine("Here is a list of numbers starting from 3, ascending by increments of 3, up to 999:");
            var num2 = 1002;
            for (int i = 3; i < num2; i += 3)
            {
                Console.WriteLine($"{i}");
            }
        }

        public static void EqualOrNot()
        {
            Console.WriteLine("Enter a number below:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number below:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            var equalOrNot = (num1 == num2) ? $"{num1} and {num2} are equal." : $"{num1} and {num2} are not equal.";
            Console.WriteLine(equalOrNot);
        }

        public static void EvenOrOdd()
        {
            Console.WriteLine("Enter a number below:");
            int num1 = int.Parse(Console.ReadLine());
            var evenOrOdd = (num1 % 2 == 0) ? $"{num1} is even." : $"{num1} is odd.";
            Console.WriteLine();
            Console.WriteLine(evenOrOdd);
        }

        public static void PosOrNeg()
        {
            Console.WriteLine("Enter a number below:");
            int num1 = int.Parse(Console.ReadLine());
            var posOrNeg = (num1 < 0) ? $"{num1} is negative." : $"{num1} is positive.";
            Console.WriteLine();
            Console.WriteLine(posOrNeg);
        }

        public static void VoteOrNot()
        {
            Console.WriteLine("Please enter age below:");
            int age = int.Parse(Console.ReadLine());
            var voteOrNot = (age >= 18) ? "You are old enough to vote! :) " : "You are not old enough to vote! :( ";
            Console.WriteLine();
            Console.WriteLine(voteOrNot);
        }

        public static void IntBetween()
        {
            Console.WriteLine("Enter any number:");
            var num = int.Parse(Console.ReadLine());
            var inBetween = (num > -10 && num < 10) ? $"{num} is between -10 and 10." : $"{num} is not between -10 and 10.";
            Console.WriteLine();
            Console.WriteLine(inBetween);
        }

        public static void MultiplicationTable()
        {
            Console.WriteLine("Enter a number to receive it's 1-12 times table:");
            var num = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"{1 * num} is {num} * 1.");
            Console.WriteLine($"{2 * num} is {num} * 2.");
            Console.WriteLine($"{3 * num} is {num} * 3.");
            Console.WriteLine($"{4 * num} is {num} * 4.");
            Console.WriteLine($"{5 * num} is {num} * 5.");
            Console.WriteLine($"{6 * num} is {num} * 6.");
            Console.WriteLine($"{7 * num} is {num} * 7.");
            Console.WriteLine($"{8 * num} is {num} * 8.");
            Console.WriteLine($"{9 * num} is {num} * 9.");
            Console.WriteLine($"{10 * num} is {num} * 10.");
            Console.WriteLine($"{11 * num} is {num} * 11.");
            Console.WriteLine($"{12 * num} is {num} * 12.");
        }
    }
}
