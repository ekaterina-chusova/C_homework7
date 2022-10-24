// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

Console.Write("Введите позицию элемента в строке: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию элемента в столбце: ");
int y = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[new Random().Next(2, 10), new Random().Next(2, 10)];

Console.WriteLine();
Console.WriteLine("Исходный массив: ");
FillArray(array);
PrintArray(array);

if (x > array.GetLength(0) || y > array.GetLength(1)) 
{
    Console.WriteLine();
    Console.WriteLine($"Элемента на позиции [{x}, {y}] не существует!");
}    
else
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == x && j == y) 
            {
                Console.WriteLine();
                Console.WriteLine($"Знaчение элемента на позиции [{x}, {y}] равно {array[i, j]}");
            }
        }
    }
}
