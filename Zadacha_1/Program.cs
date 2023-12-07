// Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

int[] FillArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 101);
    }
    return array;
}

void PrintArray(int[] MassOn)
{
    Console.Write("Массив с элементами: ");
    for(int i = 0; i < MassOn.Length; i++)
    {
        Console.Write(MassOn[i] + " ");
    }
}

void Filter(int[] num) 
{ 
    int[] n = new int[num.Length];
    Console.WriteLine(); 
    Console.Write("Элементы массива, значения которых лежат в отрезке [20, 90]: "); 

    for (int i = 0; i < num.Length; i++) 
    { 
        if (num[i] >= 20 && num[i] <= 90) 
        { 
            Console.Write(num[i] + " ");
            n[i] = num[i];
        } 
    }
    int countWithoutZeros = n.Count(x => x != 0);
    Console.WriteLine();
    Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке [20,90]: {countWithoutZeros}");
}

int sizeMass = 10;
int[] mass = FillArray(sizeMass);
PrintArray(mass);
Filter(mass);