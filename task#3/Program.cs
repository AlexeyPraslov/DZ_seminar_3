// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.

int minNumber = 1;
int maxNumber = 100;

int arraySize = 10;

double[] arrayOfnumbers = new double[arraySize];
Random random = new Random();

double min = double.MaxValue;
double max = double.MinValue;

for (int i = 0; i < arraySize; ++i)
{
    double fractionalPart = 0;
    while (fractionalPart == 0)
    {
        fractionalPart = random.NextDouble();
    }

    double currentnumber = Math.Round(random.Next(minNumber, maxNumber) + fractionalPart, 2);
    arrayOfnumbers[i] = currentnumber;

    if (min > currentnumber)
        min = currentnumber;

    if (max < currentnumber)
        max = currentnumber;
}

Console.Write("Разница между максимальным и минимальным элементами\nв массиве [");

for (int i = 0; i < arraySize; ++i)
{
    if (i > 0)
        Console.Write($", ");

    double currentNumber = arrayOfnumbers[i];
    if (currentNumber == min)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
    }
    else if (currentNumber == max)
    {
        Console.ForegroundColor = ConsoleColor.Red;
    }

    Console.Write($"{currentNumber}");
    Console.ForegroundColor = ConsoleColor.White;
}

Console.WriteLine($"] => {max - min}");


