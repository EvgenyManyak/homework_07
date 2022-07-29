int[,] CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int k = Convert.ToInt32(Console.ReadLine());
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


void CheckArray(int i, int j, int[,] array)
{
    if (i < array.GetLength(0) && j < array.GetLength(1) && i >= 0 && j >= 0)
        Console.WriteLine(array[i, j]);
    else
        Console.WriteLine("Такого числа нет");
}

int[,] array = new int[4, 4];
array = CreateArray(array);
Console.WriteLine("Введите координаты: ");
int i = Convert.ToInt32(Console.ReadLine());
int j = Convert.ToInt32(Console.ReadLine());
CheckArray(i, j, array);