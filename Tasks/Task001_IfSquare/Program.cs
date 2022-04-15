Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());

if (numberA == numberB * numberB)
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}