// Задача 29: Напишите программу, которая выводит массив из 8 элементов, и выводит их на экран

int[] array = new int[8];
void FillArray(int[] coll)
{
    int Length = coll.Length;
    int index = 0;
    while (index < Length)
    {
        coll[index] = new Random().Next(0, 10);
        index++;
    }
}
void PrintArray(int[] coll2)
{
    int count = coll2.Length;
    int position = 0;
    while (position < count)
    {

        Console.Write(coll2[position] + ", ");
        position++;
    }
}
Console.Write("[");
FillArray(array);
PrintArray(array);
Console.Write("]");