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

// class Program
// {
//     static void Main()
//     {
//         string[] names = { "Freddi", "James" };

//         // for (int i = 0; i < names.Length; i++)
//         // {
//         //     Console.WriteLine(names[i]);
//         // }

//         if (string.Equals(names[0], "freddi", StringComparison.OrdinalIgnoreCase))
//         {
//             Console.WriteLine("Igual");
//         }
//         foreach (string name in names)
//         {
//             Console.WriteLine(name);
//         }
//     }
// }

class Program
{
    static void Main()
    {
        string name = "Freddi";
        string[] names = { "John", "James" };

        int varLength = name.Length; // 6
        bool varEndWith = name.EndsWith("a"); // false  
        bool varStartsWith = name.StartsWith("a"); // false
        bool varContains = name.Contains('a'); // false

        int varIndexOf = name.IndexOf("e"); // 2
        int variableIndexOf = name.IndexOf("a"); // -1

        bool varNullOrEmpty = string.IsNullOrEmpty(name); // false
        string varJoined = string.Join(' ', names); // John James

        // Aspas únicas para um caractere, aspas duplas para mais que um caractere

        Console.WriteLine(varJoined);
    }
}