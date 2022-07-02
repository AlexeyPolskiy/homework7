// Задача 2: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1 7 -> такого числа в массиве нет

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

void SearchElement(int[,] searchArr, int searchRow, int searchCollum, int row, int collums)
{
    if (searchRow > row)
    {
        System.Console.WriteLine("такого числа в массиве нет");
        return;
    }
    if (searchCollum > collums)
    {
        System.Console.WriteLine("такого числа в массиве нет");
        return;
    }
    System.Console.WriteLine($"Искомое число {searchArr[searchRow - 1, searchCollum - 1]}");
}

int row = Promt("Введите число строк массива => ");
int collums = Promt("Введите число колон массива => ");

int searchRow = Promt("Введите номер строки искомого элемента => ");
int searchCollum = Promt("Введите номер колонки искомого элемента => ");

int elementMIN = 0;
int elementMAX = 10;

int[,] array = new int[row, collums];

FillArray(array, elementMIN, elementMAX);
PrintArray(array);
SearchElement(array, searchRow, searchCollum, row, collums);