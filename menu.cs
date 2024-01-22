namespace PoPRefactoring;

public class PopProject
{
    public static void Main()
    {
        string letter;

        Console.WriteLine("A. Saltar");
        Console.WriteLine("B. Córrer");
        Console.WriteLine("C. Ajupir-se");
        Console.WriteLine("D. Amagar-se");
        Console.Write("Escriu la lletra: ");
        letter = Console.ReadLine() ?? "".Trim();
        letter = letter.ToUpper();

        Console.WriteLine();

        if (ValidLetter(letter))
        {
            switch (letter)
            {
                case "A": Console.WriteLine("Saltar"); break;
                case "B": Console.WriteLine("Córrer"); break;
                case "C": Console.WriteLine("Ajupir-se"); break;
                case "D": Console.WriteLine("Amagar-se"); break;
            }
        }

        else Console.WriteLine("Error");
    }

    public static bool ValidLetter(string letter)
    {
        string[] validLetters = ["A", "B", "C", "D"];

        for (int i = 0; i < validLetters.Length; i++)
        {
            if (validLetters[i] == letter) return true;
        }
        return false;
    }
}