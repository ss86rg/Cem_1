string[] week = { "понеделеньник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };

Console.Write("Введите день недели: ");
string weekday = Console.ReadLine();

int dayNamber = Convert.ToInt32(weekday);
if
(dayNamber < 0 || dayNamber > 7)
{
    Console.WriteLine("нет такого дня недели");
}
else
{
    Console.WriteLine(week[dayNamber - 1]);
}