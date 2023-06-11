Console.WriteLine("введите целое положительное число");
string input_string1 = Console.ReadLine();
int namber1 = Convert.ToInt32(input_string1);
int namber2 = -namber1;
while (namber2 <= namber1)
{
    Console.Write($"{namber2}");
    namber2++;
}
