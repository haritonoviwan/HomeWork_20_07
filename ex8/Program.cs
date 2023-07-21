Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine($"Все четные числа от 1 до {number}: ");

int count = 2;
while (count <= number)
{
    if (count % 2 == 0)
    {
        Console.WriteLine(count);
    }
    count = count + 1;
}