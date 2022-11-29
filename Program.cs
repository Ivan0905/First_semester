Console.WriteLine("Введите количество строк");
int count = int.Parse(Console.ReadLine()!);
string[] array = new string[count];

for (int i = 0; i < count; i++)
{
    Console.WriteLine($"Введите строку {i + 1}");
    array[i] = Console.ReadLine()!;
}