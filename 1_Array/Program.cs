// I. Реализовать следующие функции для работы с массивами:
// Поиск минимума

Console.Write("Количество рандомных чисел: ");
int val = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[val];
int max = 0;
int min = 0;
  
for (int i = 0; i < val; i++)
{
        arr[i] = new Random().Next(1, 100);
    }
 
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
    System.Console.WriteLine();
}
PrintArray(arr);

  // Минимальное и максимальное число
min = arr[0];
max = arr[0];
for (int i = 1; i < val; i++)
{
       if (arr[i] < min)
            min = arr[i];
       if (arr[i] > max)
            max = arr[i];
}
 
Console.WriteLine("Max: " + max);
Console.WriteLine("Min: " + min);
 


