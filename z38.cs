// Задача 38: Задайте массив случайных вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементом массива.
// [4 9 17 90 3 45 54 2] -> 88;

System.Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] arr = CreateArray(size);
CreateArray(size);
MaxMinArray(arr);

double [] CreateArray(int size) 
{ 
  // принимает значение массива и возвращает сгенерированный массив                
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(100, 1000);
    return array;
}

void MaxMinArray(double[] arr)
{
    double max = 0;
    double min = 0;
    for (int i=0; i < arr.Length; i++)
    {
        if (arr[i] > max) max=arr[i];
        min = max;
        for(int j=0; j <arr.Length; j++) 
        {
            if(arr[j] < min) min = arr[j];
        }
    }
    double result = max - min;
    string Diff = string.Join(", ", arr);
    Console.Write($"[{Diff}] Разница максимального и минимального элементов массива равна = {result}");
}
