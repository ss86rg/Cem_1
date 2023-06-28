// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
//78 -> 8 
//12-> 2 
//85 -> 

Random rnd = new Random();
int temp = rnd.Next(10, 100);

System.Console.WriteLine(temp);

int Onestep = temp % 10;
int Twostep = temp / 10;
int max = -1;
if (Onestep < Twostep)
{
    max = Twostep;
    System.Console.WriteLine(max);
}
else
{
    max = Onestep;
    System.Console.WriteLine(max);
}
