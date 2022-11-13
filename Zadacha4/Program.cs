Console.Write("Введите первое число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int numberThree = Convert.ToInt32(Console.ReadLine());

if(numberOne>numberTwo && numberOne>numberThree)
{
    Console.Write("Максимальное число: ");
    Console.WriteLine(numberOne);
}
else if(numberTwo>numberThree)
{
    Console.Write("Максимальное число: ");
    Console.WriteLine(numberTwo);
}
else
{
    Console.Write("Максимальное число: ");
    Console.WriteLine(numberThree);
}