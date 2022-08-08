// Задача 38: Задайте с клавиатуры массив вещественных (double) чисел. Найдите разницу между максимальным и минимальным элементов массива.
// Задать размер (int) массива с клавиатуры
// [3 7 22 2 78] -> 76

Console.WriteLine("Введите размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
Random rand = new Random();

for (int i = 0; i < array.Length; i++)
{
   array[i] = rand.Next(-40, 40);
}
Console.WriteLine('[' + string.Join(", ", array) + ']');

double minNumber = array[0];
double maxNumber = array[0];
double result = 0;

for (int i = 0; i < array.Length; i++)
{
   if (maxNumber < array[i])
   {
      maxNumber = array[i];
   }
   if (minNumber > array[i])
   {
      minNumber = array[i];
   }
   result = maxNumber - minNumber;
}

Console.Write($"Максимальное число в массиве = {maxNumber} ");
Console.Write($"Минимальное число в массиве = {minNumber} ");
Console.Write($"Разность максимального и минимального числа = {result} ");

// Может с double и переборщил, но  мне кажеться , что преременным так же нужно присвоить значение double