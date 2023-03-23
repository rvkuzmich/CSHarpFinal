int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int n = ReadInt("Введите размер массива: ");
string[] array = new string[n];
for (int i = 0; i < n; i++)
{
    System.Console.WriteLine($"Введите {i}-й элемент массива: ");
    array[i] = Console.ReadLine();
}
System.Console.WriteLine();
System.Console.WriteLine();
List<string> newArray = new List<string>();
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        newArray.Add(array[i]);
    }
}
System.Console.Write("[");
foreach (string element in newArray)
{
    System.Console.Write(element + " ");
}
System.Console.Write("]");