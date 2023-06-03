Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
n = Math.Abs(n);

int result = 0;

while (n > 0)
{
    result += n % 10;
    n /= 10;
}

Console.WriteLine(result);
