//  Задача 69: Напишите программу, которая на вход принимает
//  два числа A и B, и возводит число А в целую 
//  степень B с помощью рекурсии.
//   A = 3; B = 5 -> 243 (3⁵)
//   A = 2; B = 3 -> 8

int ErectionNombers(int n, int b)
{
    if (b == 0)   
        return 1;       

    return n *  ErectionNombers(n, b - 1);
   
}


Console.WriteLine(ErectionNombers(6,2));
Console.WriteLine(ErectionNombers(3,5));
Console.WriteLine(ErectionNombers(2,3));