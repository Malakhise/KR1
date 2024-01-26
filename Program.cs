
string[] FillArray(string [] array)
{
    int index = 0;
    while (index < array.Length)
    {
        Console.Write("Введите строку: ");
        array[index] = Console.ReadLine()!;
        index++;
    }
    return array;
}

Console.Clear();
Console.Write("Введите число элементов массива: ");
int countElements =int.Parse(Console.ReadLine()!);
string [] array = new string[countElements];
Console.WriteLine($"[{string.Join(", ", FillArray(array))}]");
