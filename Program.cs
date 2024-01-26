
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

string[] NewArray(string [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) 
            count++; 
    }
string [] newArray = new string[count];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) 
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

Console.Clear();
Console.Write("Введите число элементов массива: ");
int countElements =int.Parse(Console.ReadLine()!);
string [] array = new string[countElements];
Console.WriteLine($"[{string.Join(", ", FillArray(array))}]");
Console.WriteLine($"[{string.Join(", ", NewArray(array))}]"); 