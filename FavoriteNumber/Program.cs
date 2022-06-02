using System;

namespace FavoriteNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //var r = new Random();
            //var favNumber = r.Next(1, 1000);
            ////var favNumber = 5;

            //Console.WriteLine("Please enter your favirote number from 1 to 1000");
            //var userInput = int.Parse(Console.ReadLine());

            //if (userInput < favNumber)
            //{
            //    Console.WriteLine($"{userInput} is too low");
            //}
            //else if (userInput > favNumber)
            //{
            //    Console.WriteLine($"{userInput} is too high");
            //}
            //else
            //{
            //    Console.WriteLine("You guessed it!!!");
            //}


            //switch case
            Console.WriteLine("Whats is your favorite subject? ");

            string subject = Console.ReadLine();

            switch(subject.ToLower())
            {
                case "math":
                    Console.WriteLine("I too love math! ");
                    break;
                case "science":
                    Console.WriteLine("I hate science! ");
                    break;
                case "pe":
                    Console.WriteLine("It's awesome! ");
                    break;
                case "history":
                    Console.WriteLine("Its boring ");
                    break;
                case "english":
                    Console.WriteLine("Wow ");
                    break;
                default:
                    Console.WriteLine("I dont know this subject");
                    break;

            }
        }
    }
}

