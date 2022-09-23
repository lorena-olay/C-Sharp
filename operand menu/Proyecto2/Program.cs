// See https://aka.ms/new-console-template for more information
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            string name;
            int number1, number2, answer, option;
            Console.WriteLine("What's your name?");
            name = Console.ReadLine();
            Console.WriteLine("Hi  " + name);
            Console.WriteLine("Tell me one number");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("and other number pls :)");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hi " + name + " choose an option");
            Console.WriteLine("What do you want to do? ");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Substract");
            Console.WriteLine("3. Divide");
            Console.WriteLine("4. Multiply");
            option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    answer = number1 + number2;
                    Console.Write("ANSWER = " + answer);
                    break;
                case 2:
                answer = number1 - number2;
                Console.Write("ANSWER = " + answer);
                    break ;
                case 3:
                    answer = number1 / number2;
                    Console.Write("ANSWER = " + answer);
                    break;
                case 4:
                    answer = number1 * number2;
                    Console.Write("ANSWER = " + answer);
                    break;
            }



            Console.ReadLine();
        }
    }
}