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

        if (ValidLetter(letter)) Console.WriteLine("Opción válida");
        else Console.WriteLine("Error");
    }

    public static bool ValidLetter(string letter)
    {
        letter = letter.ToUpper();
        string[] validLetters = ["A", "B", "C", "D"];

        for (int i = 0; i < validLetters.Length; i++)
        {
            if (validLetters[i] == letter) return true;
        }
        return false;
    }
}