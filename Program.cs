using System;

namespace PetsControl 
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet[] pets = new Pet[5];
            
            int dogCount = 0, catCount = 0, fishCount = 0;
            
            Console.WriteLine("----------Pets Control----------");
            
            for (int i = 0; i < 5; i++)
            {
                pets[i] = new Pet();

                Console.Write($"Enter the name of the pet number {i + 1}: ");
                pets[i].PetName = Console.ReadLine();
                
                bool validType = true;
                while (validType)
                {
                    Console.Write($"Enter the type of the pet number {i + 1}: ");
                    pets[i].PetType = Console.ReadLine();

                    if (pets[i].PetType.ToLower() == "dog")
                    {
                        dogCount++;
                        break;
                    } 
                    else if (pets[i].PetType.ToLower() == "cat")
                    {
                        catCount++;
                        break;
                    }
                    else if (pets[i].PetType.ToLower() == "fish")
                    {
                        fishCount++;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid type. Please enter a valid type (dog, cat, or fish).");
                        Console.Write("Would you like to inform another type [Y|N]? ");
                        string tryAgain = Console.ReadLine().ToLower();
                        if (tryAgain != "y")
                        {
                            break;
                        }
                    }
                }
            }

            Console.WriteLine("----------Total Count----------");
            Console.WriteLine($"Total dogs: {dogCount}");
            Console.WriteLine($"Total cats: {catCount}");
            Console.WriteLine($"Total fish: {fishCount}");
        }
    }
}

