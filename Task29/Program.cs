Console.Clear();
int [] array = new int [8];
for (int i = 0; i < array.Length; i++)
{
    Console.Write("Введите значение элемента массива: ");
    int n = int.Parse(Console.ReadLine()!);
    array[i] = n;
}

Console.WriteLine($"[{string.Join(", ", array)}]");