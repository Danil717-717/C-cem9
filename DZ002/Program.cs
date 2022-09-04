// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int PrintNewNombers(int m, int n)
{
    if (m > n)   
        return 0;       
    else return n + PrintNewNombers(m, n - 1);
          
}

Console.WriteLine(PrintNewNombers(1, 15));
Console.WriteLine();      
Console.WriteLine(PrintNewNombers(4, 8));
Console.WriteLine();    
