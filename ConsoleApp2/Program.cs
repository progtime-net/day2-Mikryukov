internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Как тебя зовут? Напиши: ");
        string input = Console.ReadLine();
        Console.WriteLine("Привет, " + input);
        Console.WriteLine("Сколько тебе лет?");
        input = Console.ReadLine();
        Console.WriteLine("Тебе " + input + " лет");
    }
}