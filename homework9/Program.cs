// Задача 64: Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
// Console.WriteLine("введите количество цифр");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Summ(n));

// string Summ(int n)
// {
//     if(n == 1) return("1");
//     return $"{n}" + $"{Summ(n-1)}";
// } 


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
// Console.WriteLine("введите от какаго числа");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите до какого числа");
// int a = Convert.ToInt32(Console.ReadLine());
// int i = n;

// Console.WriteLine(Summ(n,a,i));

// string Summ(int n, int a, int i)
// {
//     if(i<=n && i>=a) 
//     return $"{i}" + $"{Summ(i-1)}";
// } 

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
// функция Аккермана

Console.WriteLine("введите n");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Akker(n,m));
Int32 Akker(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Akker(n - 1, 1);
    else
      return Akker(n - 1, Akker(n, m - 1));
}