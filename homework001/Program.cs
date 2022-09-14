// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int Prompt(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
double Square(int a, int b)
{
    double count = Math.Pow(a, b);
    return count;
}
int a = Prompt("Введите число А -> ");
int b = Prompt("Введите число B -> ");
System.Console.WriteLine($"Число {a} в степени {b} = {Square(a, b)}");