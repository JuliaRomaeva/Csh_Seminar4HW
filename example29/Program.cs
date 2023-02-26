// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();
Console.Write("Введите длину массива: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимальное значение: ");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное значение: ");
int max = int.Parse(Console.ReadLine());
int[] array = FillArray(num, min, max);

int[] FillArray(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i =0; i < size; i++)
    {
        result[i] = new Random().Next(min,max);
    }
    return result;
}


Console.Write($"[{String.Join(", ", array)}]");