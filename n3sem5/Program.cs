// Задача 38: Задайте массив случайных вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(1, 10);
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]}, ");
}
void MaxMin(int[] array)
{
    int MinX = array[0];
    int MaxX = array[^1];
    int results = 0;
    foreach(int number in array)
    {
        {
            if (number < MinX)
                MinX = number;
            else if (number > MaxX)
                MaxX = number;
        }    
    }
    results = MaxX - MinX;
    Console.WriteLine($"Максимальный {MaxX} отнять минимальный {MinX} получается {results}");
}
Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size);
PrintArray(array);
MaxMin(array);

