// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int[] array = new int[4];
for (int i = 0; i < 4; i++)
    array[i] = new Random().Next(100, 1000);
int x = 0;
PrintArray(array);
Check1(array);
    Console.WriteLine($"Колличество четных чисел {x}");
void PrintArray(int[] a)
{
    for (int i = 0; i < a.Length; i++)
        Console.Write($"{a[i]}, ");
}
void Check1(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
       int j = a[i];
    if (j % 2 == 0)
        x = x + 1;
    }
}