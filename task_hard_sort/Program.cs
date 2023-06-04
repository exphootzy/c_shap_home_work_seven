// Задача HARD SORT необязательная. Считается за три обязательных
// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.

// Например, задан массив:
// 1 4 7 2
// 5 9 10 3

// После сортировки
// 1 2 3 4
// 5 7 9 10

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(-30, 30);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            System.Console.Write($"{array[i, j],3}    ");
        System.Console.WriteLine();
    }
}

int[] ConvertArrayToOne(int[,] array)
{
    int[] arrayOne = new int[array.GetLength(0) * array.GetLength(1)];
    int z = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arrayOne[z] = array[i, j];
            z++;
        }
    }
    return arrayOne;
}

int[] SortArray(int[] array)
{
    Console.WriteLine("Отсортированный массив: ");

    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length - 1 - i; j++)
        {
            if (array[j] > array[j + 1])
            {
                (array[j], array[j + 1]) = (array[j + 1], array[j]);
            }
        }
    }
    return array;
}


int[,] ConvertArrayToTwo(int[] array, int rows, int cols)
{
    int[,] arraySort = new int[rows, cols];
    int z = 0;
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
        {
            arraySort[i, j] = array[z];
            z++;
        }

    return arraySort;
}

Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Исходный массив: ");
int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);
int[] arrayOne = ConvertArrayToOne(array);
arrayOne = SortArray(arrayOne);
int[,] arrayTwo = ConvertArrayToTwo(arrayOne, rows, cols);
PrintArray(arrayTwo);




