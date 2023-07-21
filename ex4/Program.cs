Console.Write("Введите первое число: ");
int firstNumber = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите второе число: ");
int secondNumber = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите третье число: ");
int thirdNumber = int.Parse(Console.ReadLine() ?? "");

int maxNumber = firstNumber;

if (secondNumber > maxNumber)
{
    maxNumber = secondNumber;
}

if (thirdNumber > maxNumber)
{
    maxNumber = thirdNumber;
}

Console.Write($"{firstNumber}, {secondNumber}, {thirdNumber} -> {maxNumber}");