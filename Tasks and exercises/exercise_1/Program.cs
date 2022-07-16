//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// (a = 5; b = 7 -> max = 7, a = 2 b = 10 -> max = 10, a = -9 b = -3 -> max = -3)

Console.Write("Введите число 1: ");
int NumberA = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int NumberB = int.Parse(Console.ReadLine());

int max = NumberA;

if (NumberA > max) max = NumberA;
if (NumberB > max) max = NumberB;

int min = NumberA;

if (NumberA < min) min = NumberA;
if (NumberB < min) min = NumberB;

Console.Write("max=");
Console.WriteLine(max);

Console.Write("min=");
Console.WriteLine(min);