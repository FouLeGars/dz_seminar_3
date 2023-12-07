// Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.

static double[] FillArrayTwo(int length)
{
    double[] array = new double[length];
    Random random = new Random();

    for (int i = 0; i < length; i++)
    {
        double randomNumber = Math.Round(random.NextDouble() * 10, 2);
        array[i] = randomNumber;
    }
    return array;
}

void PrintArray(double[] MassOn)
{
    Console.Write("Массив с элементами: ");
    for (int i = 0; i < MassOn.Length; i++)
    {
        Console.Write(MassOn[i] + " ");
    }
}

void DifNnumbers(double[] MassOn)
{
    double max = MassOn[0];
    double min = MassOn[0];

    foreach (double num in MassOn)
    {
        if (num > max)
            max = num;

        if (num < min)
            min = num;
    }

    double difference = max - min;

    Console.WriteLine();
    Console.WriteLine($"Максимальный элемент: {max}");
    Console.WriteLine($"Минимальный элемент: {min}");
    Console.WriteLine($"Разница: {difference}");
}

int arrayLength = 25;
double[] myArray = FillArrayTwo(arrayLength);
PrintArray(myArray);
DifNnumbers(myArray);