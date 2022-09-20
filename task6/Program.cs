// Напишите программу, которая принимает на вход число и выдает, является ли число четным

Console.Write("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());
int res = num % 2;
if (res == 0)
{
    Console.Write($"Even number of {num} ");
}
else
{
    Console.Write($"Not even number of {num} ");
}