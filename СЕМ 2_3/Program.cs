//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09 
//A (7,-5); B (1,-1) -> 7,21

int ReadInt(string massege)
{
    Console.Write ($"{massege} > ");
    int value = int.Parse(Console.ReadLine());
    return value;
}

int X1 = ReadInt("Введите координату X1");
int Y1 = ReadInt("Введите координату Y1");
int X2 = ReadInt("Введите координату X2");
int Y2 = ReadInt("Введите координату Y2");

double result = Math.Sqrt(Math.Pow((X1-X2),2)+ Math.Pow((Y1-Y2),2));

Console.WriteLine($"Расстояние между двумя точками равно: {result}");



