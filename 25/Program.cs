// Задача № 25
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B

Console.Write("Введите число A : ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B : ");
int B = int.Parse(Console.ReadLine()!);

int BothNumbers(int a, int b)
{
    int result = (int)Math.Pow(a, b);
    return result;
}
Console.WriteLine($"Число {A} в степени {B} = " + BothNumbers(A, B));