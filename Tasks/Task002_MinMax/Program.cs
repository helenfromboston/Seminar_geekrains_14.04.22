Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());

if (numberA > numberB)
{
    Console.Write("max = ");
    Console.Write(numberA);
    Console.Write(", min = ");
    Console.Write(numberB);
}
else if (numberB > numberA)
{
    Console.Write("max = ");
    Console.Write(numberB);
    Console.Write(", min = ");
    Console.Write(numberA);
}
else Console.Write("Введённые числа равны");