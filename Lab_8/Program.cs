using System.Text.RegularExpressions;

class RegularExpressions
{
    public static bool ContainNumbers(string example)
    {
        Regex regular_exxpresion = new Regex(@"\d");
        return regular_exxpresion.IsMatch(example);
    }
}

class Program
{
    static void Main()
    {
        string text = "Тут є кілька цифр: 12345";

        if (RegularExpressions.ContainNumbers(text))
        {
            Console.WriteLine("Текст мiстить цифри.");
        }
        else
        {
            Console.WriteLine("Текст не мiстить цифр.");
        }
    }
}