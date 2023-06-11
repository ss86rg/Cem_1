Console.Write("Введите число =>");
string inputedString = Console.ReadLine();
int namber = Convert.ToInt32(inputedString);
Console.WriteLine("Вы ввели число" + namber + "!");
Console.WriteLine($"Вы ввели число {namber}!");

int square = namber * namber;
Console.WriteLine($"Квадрат числа {namber} равен {square}");
