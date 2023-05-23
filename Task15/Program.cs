Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
while (n < 1 || n > 7)
{
    Console.Write("Вы ошиблись! Введите номер дня недели: ");
    n = int.Parse(Console.ReadLine()!);
}
if (n == 1)
Console.WriteLine("Нет");
else if (n == 2)
Console.WriteLine("Нет");
else if (n == 3)
Console.WriteLine("Нет");
else if (n == 4)
Console.WriteLine("Нет");
else if (n == 5)
Console.WriteLine("Нет");
else if (n == 6)
Console.WriteLine("Да");
else if (n == 7)
Console.WriteLine("Да");


