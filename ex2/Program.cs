Console.Write("Введите первое число: ");
int firstNumber = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите второе число: ");
int secondNumber = int.Parse(Console.ReadLine() ?? "");

if (firstNumber > secondNumber)
{
    Console.Write($"max = {firstNumber}");
}

else if (firstNumber < secondNumber)
{
    Console.Write($"max = {secondNumber}");
}

else 
{
    Console.Write("Числа равны");
}