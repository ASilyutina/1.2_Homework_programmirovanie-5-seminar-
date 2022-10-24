// I. Реализовать следующие функции для работы с массивами:

// Заполнение массива
Console.WriteLine("Введите размер массива ");
int size = Convert.ToInt32(Console.ReadLine()); //=Int.Parse(Console.ReadLine())
int[] array = new int[size];
  
for (int i = 0; i < size; i++)
{
        array[i] = new Random().Next(-50, 100);
    }
        System.Console.WriteLine("Ваш массив:");
// Печать массива на экран
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
    System.Console.WriteLine();
}
PrintArray(array);

  // Минимальное и максимальное число
int max = 0;
int min = 0;
min = array[0];
max = array[0];
for (int i = 1; i < size; i++)
{
       if (array[i] < min)
            min = array[i];
       if (array[i] > max)
            max = array[i];
}

 //Вывод суммы элементов массива
int SumArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        sum += array[i];
    return sum;
}
  
//Вывод произведения элементов массива
int MultiplyArray(int[] array)
{
    int multiply = 1;
     for (int i = 0; i < size; i++)
            {
                multiply *= array[i];
            }
     return multiply;       
}

// Поиск индекса заданного элемента в массиве, если такого элемента в массиве нет то возвращать -1
 int IndexElement(int[] array, int N)
{
    for (int i = 0; i < array.Length; i++)
        if (array[i] == N) return i;
    return -1;
}

// Проверка наличия элемента в массиве. Возвращает true, если элемент в массиве есть, false – нет. 

     bool FindNumber(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number) return true;
    }
    return false;
}

//8. Среднее арифметическое элеметов массива
float MeanArray(int[] array)
{
    return SumArray(array)/ ((float) array.Length);
}


//9. Подсчёт количества отрицательных элементов массива
int NegativeElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] < 0) count++;
    return count;
}


//10. Подсчёт количества вхождений элемента в массив 
int Count(int[] array, int elem_count)
{
     int count_number = 0;
           for (int i = 0; i < size; i++)
                if(array[i] == elem_count)  count_number++;
                return count_number;
} 


//11,13. Подсчёт количества чётных и не четных элементов в массив
int Even(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0) count++;
    return (count);
}
int Uneven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 != 0) count++;
    return count;
}

   // 12. Подсчёт количества положительных элементов в массиве
int Positive(int[] array)
{
   int count_positive = 0;
 
            for (int i = 0; i < size; i++)
                if (array[i] > 0) count_positive++;
            return count_positive;
}

//14.Проверка является ли массив отсортированным по возрастанию. 
//Если массив отсортирован, то возвращать true, иначе - false.

bool SortArray(int[] array)
{
    for (int i = 1; i < array.Length; i++)
        if (array[i] < array[i - 1]) return false;
    return true;
}




System.Console.WriteLine("Максимальное число массива: " + max);
System.Console.WriteLine("Минимальное число массива: " + min);
System.Console.WriteLine("-----------");
System.Console.WriteLine($"Сумма чисел массива = {SumArray(array)} ");
System.Console.WriteLine("-----------");
System.Console.WriteLine($"Произведение чисел массива = {MultiplyArray(array)} ");
System.Console.WriteLine("-----------");
Console.WriteLine("Введите нужный элемент чтобы узнать его индекс:  ");
int N = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Заданный элемент массива соответсвует индексу {IndexElement(array, N)}");
System.Console.WriteLine("-----------");
Console.WriteLine("Введите искомый элемент: ");
string Result = "отсутствует";
int number = Convert.ToInt32(Console.ReadLine()); //int.Parse(Console.ReadLine());
if (FindNumber(array, number)) Result = "присутствует";
System.Console.WriteLine($"Число {number} {Result} в массиве");
System.Console.WriteLine("-----------");
System.Console.WriteLine($"Среднее арифметическое элеметов массива: {MeanArray(array)}");
System.Console.WriteLine("-----------");
System.Console.WriteLine("Количество отрицательных элементов массива: " + NegativeElements(array));
System.Console.WriteLine("-----------");
System.Console.WriteLine("Введите искомый элемент чтобы узнать количество его вхождений в массив: ");
     int elem_count = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Заданное число встречается в массиве {Count(array, elem_count)} раз/раза.");
System.Console.WriteLine("-----------");
System.Console.WriteLine($"Количество четных чисел {Even(array)}, количество нечетных чисел {Uneven(array)}");
System.Console.WriteLine("-----------");
System.Console.WriteLine("Кол-во положительных элементов: {0}", Positive(array));
System.Console.WriteLine("-----------");
System.Console.WriteLine("Ваш массив отсортирован ? ");
System.Console.WriteLine($"({SortArray(array)})");