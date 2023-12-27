//Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Введите позицию в строке:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию в столбце:");
int num2 = Convert.ToInt32(Console.ReadLine());

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
int[,] arr = FillArray(5, 5, 0, 10);
PrintArray(arr);

void FindElement(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (num1 == i && num2 == j)
            {
                Console.WriteLine(arr[i,j] + " ");
            }

        }
          
        
    }
    
}

FindElement(arr);
