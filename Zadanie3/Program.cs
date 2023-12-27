//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] FillArray(int rows, int columns, int minVaiue, int maxValue)//Заполнение массива
{
    int[,] array = new int[rows,columns];
    Random ran = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = ran.Next(minVaiue,maxValue + 1);
        }
    }
    return array;
}
void PrintArray(int[,] matrix) //вывод массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] arr = FillArray(3, 5, 0, 10);

void SumElement(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
         int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
         sum += arr[i,j];
        }
        Console.Write($"{sum} ");
    }
}

void minSumm(int[,] array)
{
    int min = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
          if (array[i, 0] <= min )
        {
            min = array[i, 0];
        }  
        }
    }
}

PrintArray(arr);
SumElement(arr);
minSumm(arr);
