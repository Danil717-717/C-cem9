// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

void PrintNewNombers(int start, int end)
{
    if (start > end)   // Первое в рекурсии нужно условие выхода
    return;       // из цикла рекурсии

    Console.Write($"{start} ");  //печатаем изменившееся n, какое то полезное действие

    PrintNewNombers(start + 1, end);           // вызов функции саму себя, собственно рекурсия
}

PrintNewNombers(1, 5);
Console.WriteLine();