// Задача 1.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5     7      -2      -0,2
// 1      -3,3    8       -9,9
// 8       7,8    -7,1    9

double[,] GenerateArray(int row, int col) // запятая внутри пустого массива обозначает двумерный массив
{
    double[,] array = new double[row, col];   // Создаем 2-мерный массив
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)    // GetLength - (берем одну размерность) количество строк | 0 означает горизонталь
    {
        for (int j = 0; j < array.GetLength(1); j++) // GetLength - количество колонок | 1 означает вертикаль
        {
            array[i, j] = random.Next(-10, 10) + random.NextDouble();
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine(); // отделение строк друг от друга
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]:f1}\t");
        }
    }
    System.Console.WriteLine();
}

double[,] matrix = GenerateArray(3, 4);
PrintArray(matrix);
