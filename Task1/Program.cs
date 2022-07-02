// Задача 1: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5  7    -2   -0,2
// 1   -3,3   8   -9,9
// 8    7,8  -7,1  9


int Promt(string msg)
{
    System.Console.Write(msg);
    int numberInt = int.Parse(Console.ReadLine());
    return numberInt;
}

double[,] FillArray(double[,] fillArr, int elementMIN, int elementMAX)
{
    for (int i = 0; i < fillArr.GetLength(0); i++)
    {
        for (int j = 0; j < fillArr.GetLength(1); j++)
        {
            fillArr[i, j] = new Random().Next(elementMIN, elementMAX+1) + new Random().NextDouble();
        }
    }
    return fillArr;
}

void PrintArray(double[,] printArr)
{
    for (int i = 0; i < printArr.GetLength(0); i++)
    {
        for (int j = 0; j < printArr.GetLength(1); j++)
        {
            System.Console.Write($"{printArr[i, j]:f1} ");
        }
    System.Console.WriteLine();
    }
    
}

int row = Promt("Введите число строк массива => ");
int collums = Promt("Введите число колон массива => ");

int elementMIN = 0;
int elementMAX = 10;

double[,] array = new double[row, collums];

FillArray(array, elementMIN, elementMAX);
PrintArray(array);