namespace PoPRefactoring;

public class PopProject
{
    public static void Main()
    {
        const string MSG_WRITE_DATE = "Introdueix el dia, mes i any amb números.";

        int dia, mes, any;
        bool validat;
        Console.WriteLine(MSG_WRITE_DATE);
        Console.Write("Dia: ");
        dia = Convert.ToInt32(Console.ReadLine());

        Console.Write("Mes: ");
        mes = Convert.ToInt32(Console.ReadLine());

        Console.Write("Any: ");
        any = Convert.ToInt32(Console.ReadLine());

        validat = ValidacióData(dia, mes, any);

        Console.WriteLine(validat ? $"La data és correcta {dia}/{mes}/{any}" : "El format no és correcte");
    }

    public static bool ValidacióData(int day, int month, int year)
    {

        if (day < 1 || day > 31)

            return false;

        if (month < 1 || month > 12)

            return false;

        // determinem la quantitat de dies del mes:

        int totalDaysMonth = 0;

        switch (month)
        {

            case 1:

            case 3:

            case 5:

            case 7:

            case 8:

            case 10:

            case 12: totalDaysMonth = 31; break;

            case 4:

            case 6:

            case 9:

            case 11: totalDaysMonth = 30; break;

            case 2: // verifica l'any de traspàs

                if ((year % 400 == 0) ||

                ((year % 4 == 0) && (year % 100 != 0)))
                    totalDaysMonth = 29;

                else totalDaysMonth = 28;

                break;
        }

        if (day > totalDaysMonth)

            return false;

        else return true;
    }
}