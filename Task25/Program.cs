Console.Clear();
Console.Write("Введите число А: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine()!);
int result = 1;

for (int i = 0; i < b; i++)
    result *= a;

if (b > 0)
    Console.WriteLine(result);
else if (b < 0 && a != 0)
    Console.WriteLine(1 / result);
else if (b == 0)
    Console.WriteLine(1);
else
    Console.WriteLine("Ошибка. Деление на ноль!");