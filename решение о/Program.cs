﻿ // Напишите программу, которая выводит случайное число из отрезка [10, 9999] и показывает наибольшую цифру числа.
//7812 -> 8 
//1213-> 3 
//845 -> 8


int MaxDigit(int number)
{
    int max = 0;
    while(number > 0)
    {
        int rest10 = number % 10;
        if (rest10 > max)
        {
            max = rest10;
        }
        number /= 10;
    }
    return max;
}

int number = new Random().Next(10,10000);
int maxDigit = MaxDigit(number);
System.Console.WriteLine($"{number} -> {maxDigit}");