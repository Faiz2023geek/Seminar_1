//Напишите программу, которая на вход принимает 2 числа и выдает, какое большее, а какое меньшее.
Console.Clear();

Console.Write("Введите первое число:");
int numberA = int.Parse(Console.ReadLine());

Console.Write("Введите второе число:");
int numberB = int.Parse(Console.ReadLine());

if (numberA > numberB)
{
Console.WriteLine($"{numberA} большее, {numberB} меньшее");
}
else
{
Console.WriteLine($"{numberA} меньшее, {numberB} большее");
}