using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:\n1 --> int\n2 --> double\n3 --> string");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.WriteLine("Please enter an integer: ");
                int first = int.Parse(Console.ReadLine());
                Console.WriteLine(first + 1);
                break;
            case "2":
                Console.WriteLine("Please enter a double: ");
                double second = double.Parse(Console.ReadLine());
                Console.WriteLine(second + 1);
                break;
            case "3":
                Console.WriteLine("Please enter a string: ");
                string third = Console.ReadLine();
                Console.WriteLine(third + '*');
                break;

            default:
                Console.WriteLine("Invalid choice !");
                break;
        }
    }
}

