void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
            matr[i, j] = new Random().Next(1, 10);
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
            Console.Write($"{matr[i, j]}");
        Console.WriteLine();
    }
}

void Transposition(int[,] matr)
{
    for (int i = 0; i < 1; i++)
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            int T = matr[i, j];
            matr[i, j] = matr[matr.GetLength(0) - 1, j];
            matr[matr.GetLength(0) - 1, j] = T;
        }

}

Console.WriteLine("Input rows: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input columns: ");
int M = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[N, M];
FillArray(matrix);
PrintArray(matrix);
Transposition(matrix);
Console.WriteLine();
PrintArray(matrix);



