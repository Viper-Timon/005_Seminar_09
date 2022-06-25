// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.WriteLine("Введите число A");
int numA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B");
int numB = int.Parse(Console.ReadLine());

//_________через VOID___________________________

// void GetNumPow(int a, int b, int comp)
// {
//    if (b == 0)
//     {
//         Console.WriteLine(comp);
//         return;
//     }
//     comp *= a;

//     GetNumPow(a, b - 1, comp);

// }

//GetNumPow(numA, numB, 1);




int GetNumPow2(int a, int b)
{
    if (b == 1) return a;

    else
    {
        a = a * GetNumPow2(a, b - 1);
        return a;
    }

}
Console.WriteLine(GetNumPow2(numA, numB));