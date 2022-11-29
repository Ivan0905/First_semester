Console.WriteLine("Введите количество строк");
int count = int.Parse(Console.ReadLine()!);
string[] array = new string[count];

for (int i = 0; i < count; i++)
{
    Console.WriteLine($"Введите строку {i + 1}");
    array[i] = Console.ReadLine()!;
}



string[] ArraySort(string[] arr)
{
    int num = 0;
    for (int j = 0; j < arr.Length; j++)
    {
        if (arr[j].Length <=3)
        {
            num++;
        }
    }
    string[] array2 = new string[num];
    num = 0;
    for (int k = 0; k < arr.Length; k++)
    {
        if (arr[k].Length <= 3)
        {
            array2[num]=arr[k];
            num++;
        }
    }
    return array2;
}