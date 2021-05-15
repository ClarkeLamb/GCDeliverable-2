using System;

namespace GCDeliverable_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string newinput = "";

            Console.WriteLine("What would you like to say to the bot?");
            input = Console.ReadLine().ToLower();

            while (input != "bye")
            {
                if (newinput == input)
                {
                    Console.WriteLine("I am sorry but you have already said this.");
                }

                else if (input == "hello")
                {
                    Console.WriteLine("hi good to see you");

                }
                else if (input == "sup")
                {
                    Console.WriteLine("I am good");

                }
                else if (input == "hello there")
                {
                    Console.WriteLine("General Kenobi");

                }
                else 
                {
                    Console.WriteLine("Sorry I do not understand.");
                }
                newinput = input;
                Console.WriteLine("Feel free to say something else!");
                input = Console.ReadLine().ToLower();




            } if (input == "bye")
            {
                Console.WriteLine("Good bye!");
            }








        }
    }
}
