void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        System.Console.Write($"{col[position]} ");
        position++;
    }
}

int[] array = new int[10];

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; //-1 т.к. если элемент в массиве отсутсвует выведится -1

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

FillArray(array);
PrintArray(array);
System.Console.WriteLine();

int pos = IndexOf(array, 8);
if (pos<0)
    System.Console.WriteLine("Числа в массиве нет");
else    
    System.Console.WriteLine($"Число находится под индексом {pos}");