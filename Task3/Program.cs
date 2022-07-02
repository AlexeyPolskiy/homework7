//  Задача 3: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int Promt(string msg)
{
    System.Console.Write(msg);
    int numberInt = int.Parse(Console.ReadLine());
    return numberInt;
}

int[,] FillArray(int[,] fillArr, int elementMIN, int elementMAX)
{
    for (int i = 0; i < fillArr.GetLength(0); i++)
    {
        for (int j = 0; j < fillArr.GetLength(1); j++)
        {
            fillArr[i, j] = new Random().Next(elementMIN, elementMAX);
        }
    }
    return fillArr;
}

void PrintArray(int[,] printArr)
{
    for (int i = 0; i < printArr.GetLength(0); i++)
    {
        for (int j = 0; j < printArr.GetLength(1); j++)
        {
            System.Console.Write($"{printArr[i, j]} ");
        }
        System.Console.WriteLine();
    }

}

void CalculateАrithmeticMeanCollum(int[,] calculateArr, int row)
{
    double answer = 0;
    double sum = 0;
    System.Console.Write("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < calculateArr.GetLength(1); j++)
    {
        for (int i = 0; i < calculateArr.GetLength(0); i++)
        {
            sum += calculateArr[i, j];
        }
        answer = sum / row;
        System.Console.Write($"{answer:f2}; ");
    }
}

int row = Promt("Введите число строк массива => ");
int collums = Promt("Введите число колон массива => ");

int elementMIN = 0;
int elementMAX = 10;

int[,] array = new int[row, collums];

FillArray(array, elementMIN, elementMAX);
PrintArray(array);
System.Console.WriteLine();
CalculateАrithmeticMeanCollum(array, row);
