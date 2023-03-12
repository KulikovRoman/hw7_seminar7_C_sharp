// Задача 2: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого числа в массиве нет
// 1, 2 -> 4

int InputInt(string message)
{
    System.Console.Write($"{message}> ");
    if (int.TryParse(Console.ReadLine(), out int value))
    {
        return value;
    }
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(1); // функция выхода из программы, выведится если что-то сработатет не корректно (код ошибки)
    return 0;
}

// метод создания и заполнения массива
int[,] GenerateMatrix(int row, int col)
{
    int[,] array = new int[row, col];   // Создаем 2-мерный массив
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)    // GetLength - (берем одну размерность) количество строк | 0 означает горизонталь
    {
        for (int j = 0; j < array.GetLength(1); j++) // GetLength - количество колонок | 1 означает вертикаль
        {
            array[i, j] = random.Next(-10, 10);
        }
    }
    return array;
}

// метод вывода массива
void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
    }
    System.Console.WriteLine();
}

// метод поиска элемента в массиве по позиции
int FindElementPosition(int[,] array, int row, int col)
{
    return array[row, col];
}


int userRow = InputInt("Введите количество строк массива");
int userCol = InputInt("Введите количество столбцов массива");
int[,] matrix = GenerateMatrix(userRow, userCol);
PrintMatrix(matrix);
int findRow = InputInt("Введите позицию строки");
int findCol = InputInt("Введите позицию столбца");
if (Validate(findRow, findCol)) System.Console.WriteLine($"Элемент с позицией [{findRow}, {findCol}] = {FindElementPosition(matrix, findRow, findCol)}");
else System.Console.WriteLine("Такого элемента нет");

// метод проверки чисел на наличие в массиве
bool Validate(int num1, int num2)
{
    if (num1 < userRow && num2 < userCol) return true;
    return false;
}