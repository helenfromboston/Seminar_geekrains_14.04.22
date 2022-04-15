Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int numberC = int.Parse(Console.ReadLine());

int max = numberA;

if (numberB > max) max = numberB;
if (numberC > max) max = numberC;

Console.Write("max = ");
Console.Write(max);