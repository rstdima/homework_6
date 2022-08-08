﻿// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// int[] array = new int[10];
int[] array ={5, 18, 123, 6, 2};

// Random rand = new Random();

// for (int i = 0; i < array.Length; i++)
// {
//    array[i] = rand.Next(10, 200);
// }

int count = 0;

for (int i = 0; i < array.Length; i++)
{
   if (array[i] >= 10 && array[i] <= 99)
   {
      count = count + 1;
   }
}
Console.Write('[' + string.Join(", ", array) + ']');
Console.WriteLine($"колличество элементов: {count}");

// Поиск эллементов в диапозоне работает [10,99], проверил с рандомным массивом и с массивом из примера. Рандомный массив закоментировал.