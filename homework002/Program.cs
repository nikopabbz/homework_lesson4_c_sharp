// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int Prompt(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
int Summ(int a)
{
    int sum = 0;
    while (a>0)
    {
        int b = a%10;
        sum = sum + b;
        a /= 10;
    }
    return sum;
}
int count = Prompt("Введите число -> ");
System.Console.WriteLine($"Сумма цифр в числе {count} = {Summ(count)}");
