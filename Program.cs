// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа
// в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

/*
void ShowNumbers(int n)
{
    Console.Write(n + " ");
    if (n > 1) 
        ShowNumbers (n - 1);
    if (n < 1) 
        ShowNumbers (n + 1);
  
}

Console.WriteLine("Input your number: ");
int num = Convert.ToInt32(Console.ReadLine());
ShowNumbers(num);
*/

// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

/*
int SumDigitsMN(int m, int n)
{   
    int sum = m;
    if (m == n) 
        return n;
    else
    {
        m++;
        sum = m - 1+ SumDigitsMN(m, n);
        return sum;
    }
}

Console.WriteLine("Input your first number: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input your second number: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

int sum = SumDigitsMN(firstNum, secondNum);
Console.WriteLine($"The sum of the numbers of the segment from {firstNum} to {secondNum} is {sum}");
*/

// Задача 68 (дополнительно): дополнительно Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

/*
int AkkermanMethod(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return AkkermanMethod(m - 1, 1);
    }
    else
    {
        return (AkkermanMethod(m - 1, AkkermanMethod(m, n - 1)));
    }
}

Console.WriteLine("Input your first number: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input your second number: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

int functionAkerman = AkkermanMethod(firstNum, secondNum);
Console.WriteLine(functionAkerman);
*/

// Задача: Написать рекурсивную функцию перевода из десятичной системы исчисления в двоичную.

/*
void DecimaltoBinary(int i)
{
    string numsBynar = string.Empty;
    
    if (i != 0)
    {
        if (i % 2 == 1)
        numsBynar += "1";
        else
        numsBynar += "0";
        DecimaltoBinary(i / 2);
    }
Console.Write(numsBynar);
}

Console.Write("Input number: ");
int numDecimal = Convert.ToInt32(Console.ReadLine());
DecimaltoBinary(numDecimal);
*/