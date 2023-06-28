// Напишите программу, которая выводит случайное число из отрезка [10, 9999] и показывает наибольшую цифру числа.
//7812 -> 8 
//1213-> 3 
//845 -> 8


Random rnm = new Random();
int temp = rnm.Next(10, 10000);
System.Console.WriteLine(temp);
int max = 0;
while (temp > 0)
{
    if (temp % 10 > max)
    {
        max = temp % 10;
    }
    temp = temp / 10;
}
System.Console.WriteLine(max);
