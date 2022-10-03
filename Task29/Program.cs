﻿int[] CreateArrayRndInt(int size,int min,int max)
{
    int [] array = new int[size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min,max+1);
    }
    return array;
}

void PrintArray (int[] array)
{
    Console.Write("[");
    for (int i = 0; i <= array.Length - 2;i++) Console.Write($"{array[i]},");
    Console.WriteLine($"{array[array.Length - 1]}]");
}
int [] arrayGlobal = CreateArrayRndInt(8,1,100);
PrintArray(arrayGlobal);