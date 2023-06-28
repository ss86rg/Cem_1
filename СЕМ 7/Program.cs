// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
//14 -> нет 
//46 -> нет 
//161 -> да



System.Console.WriteLine("Введите  число ");
string NumberOne = Console.ReadLine();
int OneNumber = Convert.ToInt32(NumberOne);
int valueOne = OneNumber % 7;
int valueTwo = OneNumber % 23;
if(valueOne == 0 && valueTwo == 0)
{
System.Console.WriteLine("Да");
} 
else
{
    System.Console.WriteLine("Нет");
}
