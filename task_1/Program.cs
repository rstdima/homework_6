// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int[] array = new int[4];
Random rand = new Random();

// int[] newArray = new int[newLength];

for(int i =0; i < array.Length; i++)
{
   array[i] = rand.Next(100,1000);// Console.WriteLine($"исходный массив {array[i]}");  
}
int count = 0;

for(int i = 0; i <array.Length; i++) {
   if( array[i] % 2 == 0){
      count = count + 1;
      // Console.WriteLine($"{array[i]}");
   } 
// Console.WriteLine($"{count}");
}
Console.WriteLine('[' + string.Join(", ", array) + ']');
Console.WriteLine('[' + string.Join(", ", count) + ']');