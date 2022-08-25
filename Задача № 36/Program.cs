// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[10];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(10, 100);
}
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 1)
    sum += array[i];
}
Console.WriteLine($"Массив: [{String.Join(", ", array)}]");
Console.WriteLine($"Сумма нечетных чисел в массиве = {sum}");
