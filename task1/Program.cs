int[,] num = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 0, 5, 3 } };

// int[,] a = new int[2,3];
// int[,,] num2 = new int[2, 3, 4];

for (int i = 0; i < num.GetLength(0); i++)
{
    for (int j = 0; j < num.GetLength(1); j++)
    {
        Console.Write($"{num[i, j]} ");
    }
    Console.WriteLine();
}
