Console.Write("Введите первое число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

if (numberOne > numberTwo)
{
    Console.Write("Большее число ");
    Console.WriteLine(numberOne);
}
else
{
    Console.Write("Большее число ");
    Console.WriteLine(numberTwo);
}