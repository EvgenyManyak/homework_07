double[,] array = new double[3, 4];
Random random = new Random();
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        array[i, j] = random.NextDouble() * 100;
        Console.Write("{0,6:F2}", array[i, j]);
    }
    Console.WriteLine();
}
