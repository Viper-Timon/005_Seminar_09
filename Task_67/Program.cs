// Задача 67: Напишите программу, 
// которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9



Console.WriteLine("Введите число N");
int numN = int.Parse(Console.ReadLine());
int summa = 0;

void GetSum(int n, int sum)
{
    if (n == 0)
    {
        Console.WriteLine(sum);
        return;
    }
    sum += n % 10;
    n = n / 10;
    GetSum(n, sum);
}

GetSum(numN, 0);

