/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

void PrintArray(int[] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
        System.Console.Write($"{matr[i]} ");
}

int[] GetRandomArray(
    int length = 12,
    int startPosition = 100,
    int finishPosition = 999)
{
    int[] array = new int[length];
    var rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(startPosition, finishPosition + 1);
    }
    return array;
}


int CountEvenNumbersInArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}

int[] myArray = GetRandomArray(16, 100, 999);
PrintArray(myArray);
System.Console.Write($" -> {CountEvenNumbersInArray(myArray)}");

