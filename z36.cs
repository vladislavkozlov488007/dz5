// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму 
// элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19; [-4, -6, 89, 6] -> 0;

void OddPlace() 
{
    int size = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int[size];
    int sum = 0;
    for(int i=0; i<arr.Length; i++) 
    {
        arr[i] = new Random().Next(-10, 10);
        if(i % 2 != 0)
        sum += arr[i]; // складываем нечетные элементы массива
    }
    string SumNegative = string.Join(", ", arr);
    System.Console.WriteLine($"Сумма элементов, стоящая на нечетных позициях в массиве [{SumNegative}] равна {sum}");
}

System.Console.WriteLine("Задайте размер массива ");
OddPlace();

