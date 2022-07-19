// Console.Write("Insert your name: ");
// string name = Console.ReadLine();
// 
// Console.WriteLine($"It's nice to meet you, {name}!");
// 
// Console.Write("Insert the year you were born: ");
// int year = int.Parse(Console.ReadLine());
// 
// int age = 2022 - year;
// Console.WriteLine($"You are {age} years old.");
// 
// if (age < 18)
// {
// Console.WriteLine($"You are underage");
// }
// else
// {
// Console.WriteLine("You are an adult");
// };

// --------------------------------

class Program
{
    static void Main()
    {
        string[] names = { "Freddi", "James" };

        // for (int i = 0; i < names.Length; i++)
        // {
        //     Console.WriteLine(names[i]);
        // }

        if (string.Equals(names[0], "freddi", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Igual");
        }
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
}
