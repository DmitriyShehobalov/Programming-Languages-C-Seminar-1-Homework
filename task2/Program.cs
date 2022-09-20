// Задача 2: Напишите программу, которая на вход принимает 2 числа и выдает какое число большее, а какое меньшее

Console.Write("Enter first number: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter first number: ");
int numberB = Convert.ToInt32(Console.ReadLine());


if (numberA > numberB)
{
    Console.Write($" Max num = {numberA} min num = {numberB}");
}
else
{
 Console.Write($" Max num = {numberB} min num = {numberA}");
}