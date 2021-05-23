using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What do you want to do? [list, quit]");
            string[] animals = { "wolf", "tiger", "bear", "cat", "dog", "bird" };
            string answer = Console.ReadLine();
            while (true)
            {
                if (answer == "quit")
                {
                    break;
                }
                if (answer == "list")
                {
                    Console.WriteLine("Here they are:");
                    foreach (string all in animals)
                    {
                        Console.WriteLine(all);
                    }
                    Console.WriteLine("Which animal do you want to see?");
                    string animal = Console.ReadLine();
                    if (animal == "cat")
                    {
                        string name = animal;
                        while (true)
                        {
                            Console.WriteLine("What do you want to do? [Eat, MakeSound, ComeHere, GiveName, back, quit]");
                            string action = Console.ReadLine();
                            if (action == "back")
                            {
                                break;
                            }
                            if (action == "quit")
                            {
                                Environment.Exit(0);
                            }
                            if (action == "Eat")
                            {
                                Console.WriteLine(name + " eats");
                            }
                            if (action == "MakeSound")
                            {
                                Console.WriteLine("Meow");
                            }
                            if (action == "ComeHere")
                            {
                                Console.WriteLine(name + " walks to you");
                            }
                            if (action == "GiveName")
                            {
                                name = Console.ReadLine();
                                Console.WriteLine("Cat is now called " + name);
                            }
                        }
                    }
                }
            }
        }
    }
}
