string[] input = ["Test", "Two", "8", ":-)", "String", "!"];
Console.WriteLine("Входной массив:");
PrintArray(input);

int count = 0;

for (int i = 0; i < input.Length; i++)
{
    if (input[i].Length <= 3)
    {
        count++;
    }
}

string[] output = new string[count];
int j = 0;

for (int i = 0; i < input.Length; i++)
{
    if (input[i].Length <= 3)
    {
        output[j] = input[i];
        j++;
    }
}

Console.WriteLine("Выходной массив:");
PrintArray(output);

void PrintArray(string[] arr)
{
    Console.Write("[ ");
    if (arr.Length > 1)
    {
        Console.Write(arr[0]);
    }
    for (int i = 1; i < arr.Length; i++)
    {
        Console.Write(", ");
        Console.Write(arr[i]);
    }
    Console.Write(" ]\n");
}