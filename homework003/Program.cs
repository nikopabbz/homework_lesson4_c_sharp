// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int Prompt(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
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
int size = Prompt("Введите размер массива -> ");
int[] array = Array(size);
SetOutput(array);

