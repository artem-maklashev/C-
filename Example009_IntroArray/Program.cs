int Max(int[] arr)
{
    int result = arr[0];
    foreach (var num in arr)
    {
        if (num > result) result = num;
    }
    return result;
}

int[] array = { 1, 21, 31, 41, 15, 61, 17, 18, 9 };

System.Console.WriteLine(Max(array));