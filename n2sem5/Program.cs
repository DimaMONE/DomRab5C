// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
//  стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int[] array = new int[4];
for (int i = 0; i < 4; i++)
    array[i] = new Random().Next(10, 100);
int x = 0;
PrintArray(array);
Check1(array);
    Console.WriteLine($"Сумма элементов равна {x}");
void PrintArray(int[] a)
{
    for (int i = 0; i < a.Length; i++)
        Console.Write($"{a[i]}, ");
}
void Check1(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
    if (i % 2 == 1)
        x = x + a[i];
    }
}