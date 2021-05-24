using System;

<<<<<<< HEAD
namespace Team_software_project
=======
namespace ConsoleApp10
>>>>>>> 23bd3c5b3fe947725a2ba58e9c5431b9af6171a0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What do you want to do? [list, quit]");
<<<<<<< HEAD
            string[] animals = { "0 - bear", "1 - cat", "2 - dog", "3 - bird" };
=======
            string[] animals = { "wolf", "tiger", "bear", "cat", "dog", "bird" };
>>>>>>> 23bd3c5b3fe947725a2ba58e9c5431b9af6171a0
            string answer = Console.ReadLine();
            while (true)
            {
                if (answer == "quit")
                {
                    break;
                }
<<<<<<< HEAD

=======
>>>>>>> 23bd3c5b3fe947725a2ba58e9c5431b9af6171a0
                if (answer == "list")
                {
                    Console.WriteLine("Here they are:");
                    foreach (string all in animals)
                    {
                        Console.WriteLine(all);
                    }
<<<<<<< HEAD


                    Console.WriteLine("Which animal do you want to see? Give number of the animal 0-3");
                    int animal = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(animals[animal]);
                    if (animal == 0)
                    {
                        int weight = 0;
                        string name = "bear";
                        while (true)
                        {

                            Console.WriteLine("What do you want to do? [Eat, MakeSound, ComeHere, GiveName, back, quit]");
                            string action = Console.ReadLine();

=======
                    Console.WriteLine("Which animal do you want to see?");
                    string animal = Console.ReadLine();
                    if (animal == "cat")
                    {
                        string name = animal;
                        while (true)
                        {
                            Console.WriteLine("What do you want to do? [Eat, MakeSound, ComeHere, GiveName, back, quit]");
                            string action = Console.ReadLine();
>>>>>>> 23bd3c5b3fe947725a2ba58e9c5431b9af6171a0
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
<<<<<<< HEAD
                                weight++;
                                Console.WriteLine(name + " eats, gains 1 kg and weighs now " + weight + " kg");
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
=======
                                Console.WriteLine(name + " eats");
>>>>>>> 23bd3c5b3fe947725a2ba58e9c5431b9af6171a0
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
<<<<<<< HEAD
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
=======
                                name = Console.ReadLine();
                                Console.WriteLine("Cat is now called " + name);
>>>>>>> 23bd3c5b3fe947725a2ba58e9c5431b9af6171a0
                            }
                        }
                    }
                }
            }
        }
    }
}
<<<<<<< HEAD

=======
>>>>>>> 23bd3c5b3fe947725a2ba58e9c5431b9af6171a0
