// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
System.Console.WriteLine("Наши трехзначные числа:");
int[] array = CreateArray(5);
PrintArray(array);
System.Console.WriteLine($"Количество четных чисел в массиве равно {CountNumbers(array)} ");

int[] CreateArray(int size) // принимает значение массива и возвращает 
{                           // сгенерированный массив
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(100, 1000);
    return array;
}
void PrintArray(int[] array)
{
    foreach (int el in array) // этот цикл только для просмотра и тут нет индексов
        System.Console.Write($"{el} ");
    // for (int i = 0; i<array.Length; i++)
    // Console.Write($"{arrai[i]}");
    System.Console.WriteLine();
}
int CountNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
            count++;
    return count;
}
