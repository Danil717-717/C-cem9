//  Задача 68: Напишите программу вычисления функции
//  Аккермана с помощью рекурсии. Даны два 
//  неотрицательных числа m и n. 
//  m = 2, n = 3 -> A(m,n) = 29


int RecFunAkker(int m, int n)
{
    // Базовый случай
    if (m == 0)
    {
        return n + 1;
    } // Шаг рекурсии / рекурсивное условие
    else if (n == 0 && m > 0)
    {
        return RecFunAkker(m - 1, 1);
    } // Шаг рекурсии / рекурсивное условие
    else
    {
        return RecFunAkker(m - 1, RecFunAkker(m, n - 1));
    }
}

Console.WriteLine(RecFunAkker(3, 2)); 

