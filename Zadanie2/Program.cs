//Задайте двумерный массив. Напишите программу, 
//которая поменяет местами первую и последнюю строку массива.

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

int[,] matrix = FillArray(5, 5, 0, 10);

void ZamElement(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(1); i++)
            {
                var temp = arr[4, i];
                arr[4, i] = arr[0, i];
                arr[0, i] = temp;
            }
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
            }
           
 }
    

PrintArray(matrix);
ZamElement(matrix);

