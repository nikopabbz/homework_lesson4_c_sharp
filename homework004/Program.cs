// Задачи 4: (*) Напишите программу, которая задаёт массив из 8 элементов случайными числами и выводит их на экран. 
// Также ищет второй максимум (число меньше максимального элемента, но больше всех остальных) 

int[] Array(int len)
{
    int[] array = new int[len];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}
void SetOutput(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
}
int SecondMax(int[] array)
{
    int max = 0;
    int secondMax = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) 
        {
            secondMax = max;
            max = array[i];
        }
        else if (array[i] > secondMax && array[i] < max)
        {
            secondMax = array[i];
        }
    }
    return secondMax;
}

int[] array = Array(8);
SetOutput(array);
System.Console.WriteLine();
System.Console.WriteLine($"Второе максимальное число в массиве -> {SecondMax(array)}");
