/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

string fmt = "0.000";

void PrintArray(double[] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
        System.Console.Write($"{matr[i].ToString(fmt)} ");
}

double[] GetRandomArray(
    int length = 12,
    int range = 100)
{
    double[] array = new double[length];
    var rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.NextDouble() * range;
    }
    return array;
}


double MaxMinDiffInArray(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    return max - min;
}

double[] myArray = GetRandomArray(16, 100);
PrintArray(myArray);
System.Console.Write($" -> {MaxMinDiffInArray(myArray).ToString(fmt)}");