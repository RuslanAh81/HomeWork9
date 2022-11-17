/// Задача 64. Задайте значение N. Напишите программу, которая выведет все натуральные  числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
void ShowNums(int a)
{
    if (a < 1)
    {
        Console.Write(a + " ");
        ShowNums(a + 1);
    }
    else

    Console.Write(a + " ");
    if(a > 1) ShowNums(a - 1);

}
Console.Write(" Ведите число n ");
int n = Convert.ToInt32(Console.ReadLine());
ShowNums(n);
*/

///Задача 66. Задайте значения M и N. Напишите программу,которая найдет сумму натуральных элементов в промежутке от N до M.

int Summ(int m, int n)
{
    if(m<n) return Summ(m,n-1) + n;
    if(m>n) return Summ(m-1,n) + m;
        
    else return  m ;
}
Console.WriteLine("Введите число m");
int m= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n");
int n= Convert.ToInt32(Console.ReadLine());

Console.Write(Summ(m,n));


/// задача 68. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны 2 неотрицательных числа m и n.
/*
int Akkerman(int m, int n)
{
    if(m==0)
    return n+1;

    else
    
    if(m>0 && n==0)
    return Akkerman(m-1,1);

    else                                    // if (m>0 && n >0)
    return Akkerman(m-1,Akkerman(m,n-1));    
    
}

Console.WriteLine(Akkerman(3,4));
*/