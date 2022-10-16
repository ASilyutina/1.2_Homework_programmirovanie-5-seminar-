// I. Реализовать следующие функции для работы с массивами:


Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine()); //=Int.Parse(Console.ReadLine())
int[] array = new int[size];
int max = 0;
int min = 0;
  
for (int i = 0; i < size; i++)
{
        array[i] = new Random().Next(1, 100);
    }
 System.Console.WriteLine("Ваш массив:");
 System.Console.WriteLine();
// вывод элементов массива
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
    System.Console.WriteLine();
}
PrintArray(array);
System.Console.WriteLine();
  // Минимальное и максимальное число
min = array[0];
max = array[0];
for (int i = 1; i < size; i++)
{
       if (array[i] < min)
            min = array[i];
       if (array[i] > max)
            max = array[i];
}
Console.WriteLine("Максимальное число массива: " + max);
Console.WriteLine("Минимальное число массива: " + min);
System.Console.WriteLine();
 //Вывод суммы элементов массива
{
    int sum = 0;
    for (int i = 0; i < size; i++)
    {
          if (array[i]> 0) sum += array[i];
    }
    System.Console.WriteLine($"Сумма чисел массива = {sum} ");
}
System.Console.WriteLine();
//Вывод произведения элементов массива
{
    int multiply = 1;
     for (int i = 0; i < size; i++)
            {
                multiply *= array[i];
            }
            Console.WriteLine($"Произведение чисел массива = {multiply} ");
}
System.Console.WriteLine();
// Поиск индекса заданного элемента в массиве, если такого элемента в массиве нет то возвращать -1
 Console.WriteLine("Введите нужный элемент: ");
           int elem = Convert.ToInt32(Console.ReadLine()); //int.Parse(Console.ReadLine());
 
            for (int i = 0; i < size; i++)
            {
                if (array[i] == elem)
                {
                    Console.WriteLine($"Индекс заданного элемента {elem}: " + i);
                    break;
                }
 
                if (i == size - 1) Console.WriteLine("Такого элемета нет");
            }
  System.Console.WriteLine();
// Проверка наличия элемента в массиве. Возвращает true, если элемент в массиве есть, false – нет. 
 Console.WriteLine("Введите искомый элемент: ");
 string Result = "отсутствует";
           int number = Convert.ToInt32(Console.ReadLine()); //int.Parse(Console.ReadLine());
     bool FindNumber(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number) return true;
    }
    return false;
}
if (FindNumber(array, number)) Result = "присутствует";
System.Console.WriteLine($"Число {number} {Result} в массиве");
System.Console.WriteLine();

//8. Среднее арифметическое элеметов массива
{
    int average = 0;
    for (int i = 0; i < size; i++)
    {
          if (array[i]> 0) average += array[i];
    }
    average= average/size;
    System.Console.WriteLine($"Среднее арифметическое элементов массива = {average} ");
}
System.Console.WriteLine();