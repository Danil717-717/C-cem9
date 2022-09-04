// Задача 59: Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец,
//  на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}\t");
        }
        Console.WriteLine();
    }
}

int [] FindMinElementMatrix(int[,] matrix)  // поиск мин элемента
{
    int minI = 0;
    int minJ = 0;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i, j] < matrix[minI, minJ])
            {
                minI = i;
                minJ = j;
            }
        }
    }
    int [] minArray = new int [] {minI, minJ};
    return minArray;
}

void PrintNewMatrix(int[,] array, int minI, int minJ)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if (i != minI && j != minJ) Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}


int [,] array = new int[,]
{
    {9, 6, 7, 6},
    {8, 5, 4, 3},
    {7, 7, 5, 4},
    {6, 7, 5, 4}
};

PrintMatrix(array);
int[] minArray = FindMinElementMatrix(array); //Массив содержащий minI и minJ
int minI = minArray[0];
int minJ = minArray[1];
Console.WriteLine($"Минимальный элемент имеет индекс({minI}, {minJ}\t");
PrintNewMatrix(array,minI, minJ);