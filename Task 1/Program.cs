/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/
int [] EnterArray(int length)
{
int [] array = new int [length];
for (int i = 0; i < length; i++)
{
    Console.WriteLine("Введите число:");
    int number = Convert.ToInt32(Console.ReadLine());
    array[i] = number;
}
return array;
}
void PrintArray(int [] array)
{
    foreach (int item in array)
    {
        Console.Write($"{item} ");
    }
}
int CountOfPositiveNumbers(int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] > 0) count++;
    }
    return count;
}

Console.WriteLine("Задайте количество вводимых чисел");
int m = int.Parse(Console.ReadLine());
int [] arr = EnterArray(m);

Console.WriteLine("Введенный массив: ");
PrintArray(arr);
Console.WriteLine();

int positiveCount = CountOfPositiveNumbers(arr);
Console.WriteLine($"Количество положительных чисел в массиве равно {positiveCount}");
