Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
while (n < 100 || n > 999)
{
    Console.Write("Введите число: ");
    n = int.Parse(Console.ReadLine()!);
}
Console.WriteLine(n = (n / 10) % 10) ;
