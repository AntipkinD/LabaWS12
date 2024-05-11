using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите IPV4 адрес: ");
        string ip = Console.ReadLine();
        Regex reg = new Regex(@"\b(([01]?\d\d?|2([0-4]\d|5[0-5]))\.){3}([01]?\d\d?|2([0-4]\d|5[0-5]))$*\b");
        MatchCollection matches = reg.Matches(ip);
        Console.WriteLine("Список содержащихся в тексте IPV4 адресов:");
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}