/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

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


int SumOfEvenPositionsInArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((i + 1) % 2 == 0) sum += array[i];
    }
    return sum;
}

int[] myArray = GetRandomArray(9, 10, 99);
PrintArray(myArray);
System.Console.Write($" -> {SumOfEvenPositionsInArray(myArray)}");

