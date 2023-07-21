Console.Write("Введите первое число: ");
int firstNumber = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите второе число: ");
int secondNumber = int.Parse(Console.ReadLine() ?? "");

if (firstNumber > secondNumber)
{
    Console.Write($"a = {firstNumber}; b = {secondNumber} -> max = {firstNumber}");
}

else if (firstNumber < secondNumber)
{
    Console.Write($"a = {firstNumber}; b = {secondNumber} -> max = {secondNumber}");
}

else 
{
    Console.Write($"a = {firstNumber}; b = {secondNumber} -> Числа равны");
}