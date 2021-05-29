﻿using System;
namespace Team_software_project
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            int a = 0;
            Console.WriteLine("What do you want to do? [list, quit]");
            string[] animals = { "0 - bear", "1 - cat", "2 - dog", "3 - bird", "4 - wolf", "5 - tiger" };
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


                    Console.WriteLine("Which animal do you want to see? Give number of the animal 0-5");
                    int animal = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(animals[animal]);
                    if (animal == 0)
                    {
                        int weight = 0;
                        string name = "bear";
                        while (true)
                        {

                            Console.WriteLine("What do you want to do? [Hunt, MakeSound, ComeHere, GiveName, back, quit]");
                            string action = Console.ReadLine();

                            if (action == "back")
                            {
                                break;
                            }
                            if (action == "quit")
                            {
                                Environment.Exit(0);
                            }
                            if (action == "Hunt")
                            {
                                a = rand.Next(0, 10);
                                if (a < 6)
                                {
                                    weight++;
                                    Console.WriteLine("Hunt was successful, " + name + " gains 1 kg and weighs now " + weight + " kg");
                                }
                                else
                                {
                                    Console.WriteLine("Hunt failed, " + name + " still weights " + weight + " kg");
                                }
                                
                            }
                            if (action == "MakeSound")
                            {
                                Console.WriteLine("Growl");
                            }
                            if (action == "ComeHere")
                            {
                                Console.WriteLine(name + " walks to you");
                            }
                            if (action == "GiveName")
                            {
                                Console.WriteLine("Give a name:");
                                name = Console.ReadLine();
                                Console.WriteLine("bear is now called " + name);
                            }
                        }
                    }
                    if (animal == 1)
                    {
                        int weight = 0;
                        string name = "cat";
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
                                weight++;
                                Console.WriteLine(name + " eats, gains 1 kg and weighs now " + weight + " kg");
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
                                Console.WriteLine("Give a name:");
                                name = Console.ReadLine();
                                Console.WriteLine("cat is now called " + name);
                            }
                        }
                    }
                    if (animal == 2)
                    {
                        int weight = 0;
                        string name = "dog";
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
                                weight++;
                                Console.WriteLine(name + " eats, gains 1 kg and weighs now " + weight + " kg");
                            }
                            if (action == "MakeSound")
                            {
                                Console.WriteLine("Woof");
                            }
                            if (action == "ComeHere")
                            {
                                Console.WriteLine(name + " walks to you");
                            }
                            if (action == "GiveName")
                            {
                                Console.WriteLine("Give a name:");
                                name = Console.ReadLine();
                                Console.WriteLine("dog is now called " + name);
                            }
                        }
                    }
                    if (animal == 3)
                    {
                        int weight = 0;
                        string name = "bird";
                        while (true)
                        {

                            Console.WriteLine("What do you want to do? [Hunt, MakeSound, ComeHere, GiveName, back, quit]");
                            string action = Console.ReadLine();

                            if (action == "back")
                            {
                                break;
                            }
                            if (action == "quit")
                            {
                                Environment.Exit(0);
                            }
                            if (action == "Hunt")
                            {
                                a = rand.Next(0, 10);
                                if (a < 6)
                                {
                                    weight++;
                                    Console.WriteLine("Hunt was successful, " + name + " gains 1 kg and weighs now " + weight + " kg");
                                }
                                else
                                {
                                    Console.WriteLine("Hunt failed, " + name + " still weights " + weight + " kg");
                                }
                            }
                            if (action == "MakeSound")
                            {
                                Console.WriteLine("Chirp");
                            }
                            if (action == "ComeHere")
                            {
                                Console.WriteLine(name + " flies to you");
                            }
                            if (action == "GiveName")
                            {
                                Console.WriteLine("Give a name:");
                                name = Console.ReadLine();
                                Console.WriteLine("bird is now called " + name);
                            }
                        }
                    }
                    if (animal == 4)
                    {
                        int weight = 0;
                        string name = "wolf";
                        while (true)
                        {

                            Console.WriteLine("What do you want to do? [Hunt, MakeSound, ComeHere, GiveName, back, quit]");
                            string action = Console.ReadLine();

                            if (action == "back")
                            {
                                break;
                            }
                            if (action == "quit")
                            {
                                Environment.Exit(0);
                            }
                            if (action == "Hunt")
                            {
                                a = rand.Next(0, 10);
                                if (a < 6)
                                {
                                    weight++;
                                    Console.WriteLine("Hunt was successful, " + name + " gains 1 kg and weighs now " + weight + " kg");
                                }
                                else
                                {
                                    Console.WriteLine("Hunt failed, " + name + " still weights " + weight + " kg");
                                }

                            }
                            if (action == "MakeSound")
                            {
                                Console.WriteLine("Howl");
                            }
                            if (action == "ComeHere")
                            {
                                Console.WriteLine(name + " walks to you");
                            }
                            if (action == "GiveName")
                            {
                                Console.WriteLine("Give a name:");
                                name = Console.ReadLine();
                                Console.WriteLine("wolf is now called " + name);
                            }
                        }
                    }
                    if (animal == 5)
                    {
                        int weight = 0;
                        string name = "tiger";
                        while (true)
                        {

                            Console.WriteLine("What do you want to do? [Hunt, MakeSound, ComeHere, GiveName, back, quit]");
                            string action = Console.ReadLine();

                            if (action == "back")
                            {
                                break;
                            }
                            if (action == "quit")
                            {
                                Environment.Exit(0);
                            }
                            if (action == "Hunt")
                            {
                                a = rand.Next(0, 10);
                                if (a < 6)
                                {
                                    weight++;
                                    Console.WriteLine("Hunt was successful, " + name + " gains 1 kg and weighs now " + weight + " kg");
                                }
                                else
                                {
                                    Console.WriteLine("Hunt failed, " + name + " still weights " + weight + " kg");
                                }

                            }
                            if (action == "MakeSound")
                            {
                                Console.WriteLine("Roar");
                            }
                            if (action == "ComeHere")
                            {
                                Console.WriteLine(name + " walks to you");
                            }
                            if (action == "GiveName")
                            {
                                Console.WriteLine("Give a name:");
                                name = Console.ReadLine();
                                Console.WriteLine("tiger is now called " + name);
                            }
                        }
                    }
                }
            }
        }
    }
}

