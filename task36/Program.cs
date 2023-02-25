// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}
Console.WriteLine("Задайте размер массива:");
int[] array = GetArray(Convert.ToInt32(Console.ReadLine()),1,999);
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i % 2 != 0)
    {
        count += array[i];
    }
}
Console.WriteLine($"В массиве - [{String.Join(";", array)}] сумма чисел стоящих на нечетных позициях равна {count}");