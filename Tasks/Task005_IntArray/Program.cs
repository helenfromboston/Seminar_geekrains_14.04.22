Console.Write("Введите число: ");
int numberA = int.Parse(Console.ReadLine());
int numberB = -numberA;

while (numberB <= numberA)
{
    Console.Write(numberB);
    Console.Write(" ");
    numberB = numberB + 1;
}