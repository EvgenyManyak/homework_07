int[,] CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int k = new Random().Next(1, 10);
            array[i, j] = k;
        }
    }
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    return array;
}

void AvgArray(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        double avg = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        {
            avg = avg + array[j, i];
        }
        Console.WriteLine(avg / array.GetLength(0));
    }
}

int[,] array = new int[4, 4];
array = CreateArray(array);
AvgArray(array);
