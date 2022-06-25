// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число M");
int numM = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N");
int numN = int.Parse(Console.ReadLine());


int FindSumNaturalBtwn(int m, int n)
{
    if (m > n)
    {
        Console.WriteLine("Число M больше числа N");
        return m;
    }
    else if (m < n)
    {
        m = m + FindSumNaturalBtwn(m + 1, n);
        return m;
    }
    else return m;
}

Console.WriteLine($"Сумма натуральных чисел между M и N = {FindSumNaturalBtwn(numM, numN)}");

