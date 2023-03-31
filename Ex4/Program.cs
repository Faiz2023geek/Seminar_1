//Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N.
Console.Clear();

Console.Write("Введите число:");
int number = int.Parse(Console.ReadLine());
int count = 2;

while (count <= number)
{
    Console.Write($"{count}");
    count += 2;
}
