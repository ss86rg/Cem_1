internal class Program
{
    private static void Main(string[] args)
    {
        // новая задача 
        Console.Write("Введите число 1 =>");
        string inputedString1 = Console.ReadLine();
        Console.Write("Введите число 2 =>");
        string inputedString2 = Console.ReadLine();

        int namber1 = Convert.ToInt32(inputedString1);
        Console.WriteLine($"Вы ввели число {namber1}!");
        int namber2 = Convert.ToInt32(inputedString2);
        Console.WriteLine($"Вы ввели число {namber2}!");

        if (namber2 == namber1 * namber1)
        {
            Console.WriteLine($"Число  {namber2} не является квадратом {namber1}");
        }
        else
        {
            Console.WriteLine($"Число  {namber1} является квадратом {namber2}");
        }
    }
}
