// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
// Используйте NextDouble().
double[] numbers = new double[10];
for (int i = 0; i < 10; i++)
{
    numbers[i] = new Random().NextDouble() * 100;
}

double min = numbers[0];
int minIndex = 0;
for (int j = 0; j < 10; j++)
{
	if (min > numbers[j])
	{
		min = numbers[j];
		minIndex = j;
	}
}

double max = numbers[0];
int maxIndex = 0;
for (int y = 0; y < 10; y++)
{
	if (max < numbers[y])
	{
		max = numbers[y];
		maxIndex = y;
	}
}

Console.WriteLine($"Массив - [{String.Join(";", numbers)}]");
Console.WriteLine($"Разница между максимальным и минимальным значением {numbers[maxIndex] - numbers[minIndex]}");

