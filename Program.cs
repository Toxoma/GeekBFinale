string [] mas = new string[] { "Tom", "Sam", "Bo", "Kate", "Toa", "Alice", "2", ":-)" };

string [] Rabota(string [] array)
{
    string [] result = new string[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result = result.Append(array[i]).ToArray();
        }
    }
    return result;
}

void Vivod<T>(T[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{i}) {array[i]}");
    }
}

string [] result = Rabota(mas);
Vivod(result);
