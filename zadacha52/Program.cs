// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

void FillArray(int[,] numbers) //заполняем массив случайными числами
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] numbers) //выводим массив в консоль
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write($"{numbers[i, j]} ");
        }
        Console.WriteLine();
    }
}

void Median(int[,] numbers) //находим и выводим в консоль среднее арифетическое по столбцам
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            sum += numbers[i, j];
        }
        System.Console.Write($"{Math.Round(sum / numbers.GetLength(0), 2)} ");
    }
}

System.Console.WriteLine("Введите количество строк в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество cтолбцов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];
FillArray(array);
System.Console.WriteLine("Массив имеет вид: ");
PrintArray(array);
System.Console.WriteLine("Среднее арифметическое по столбцам: ");
Median(array);
