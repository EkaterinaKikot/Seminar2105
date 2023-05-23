Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
while (n < 100 || n > 999)
{
    Console.Write("Третьей цифры нет! Введите число: ");
n = int.Parse(Console.ReadLine()!);
}
Console.WriteLine(n % 10);
