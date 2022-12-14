/* I. Реализовать следующие функции для работы с массивами:
1. Поиск минимума
2. Поиск максимума
3. Поиск суммы элементов массива
4. Поиск произведения элементов массива
5. Поиск индекса заданного элемента в массиве, если такого элемента в массиве нет то возвращать -1
6. Проверка наличия элемента в массиве. Возвращает true, если элемент в массиве есть, false – нет.
7. Печать массива на экран
8. Среднее арифметическое элеметов массива
9. Подсчёт количества отрицательных элементов массива
10. Подсчёт количества вхождений элемента в массив
11. Подсчёт количества чётных элементов в массив
12. Подсчёт количества положительных элементов в массиве
13. Подсчёт количества нечётных элементов в массиве
14. Проверка является ли массив отсортированным по возрастанию. Если массив отсортирован, то возвращать true, иначе - false.
*/

// Заполнение массива
void FillArray(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(min, max);
}

// Печать массива на экран
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i]);
}

// Поиск минимума
int MinValue(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
        if (array[i] < min) min = array[i];
    return min;
}

// Поиск максимума
int MaxValue(int[] array)
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
        if (array[i] > max) max = array[i];
    return max;
}

// Поиск суммы элементов массива
int SumArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        sum += array[i];
    return sum;
}

// Поиск произведения элементов массива
int MultiplicationArray(int[] array)
{
    int mulriplication = 1;
    for (int i = 0; i < array.Length; i++)
        mulriplication *= array[i];
    return mulriplication;
}

//Поиск индекса заданного элемента в массиве, если такого элемента в массиве 
//нет то возвращать -1
int IndexElement(int[] array, int N)
{
    for (int i = 0; i < array.Length; i++)
        if (array[i] == N) return i;
    return -1;
}

// Проверка наличия элемента в массиве. Возвращает true, если элемент в массиве есть,
//false – нет.
bool ElementArray(int[] array, int value)
{
    for (int i = 0; i < array.Length; i++)
        if (array[i] == value) return true;
        return false;
}

// Среднее арифметическое элеметов массива
float MeanArray(int[] array)
{
    return SumArray(array)/ ((float) array.Length);
}

// Подсчёт количества отрицательных элементов массива
int NegativeElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] < 0) count++;
    return count;
}

// Подсчёт количества вхождений элемента в массив
int Count(int[] array, int a)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] == a) count++;
    return count;
}

// Подсчёт количества чётных элементов в массив
int ChetElement(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0) count++;
    return (count);
}

// Подсчёт количества положительных элементов в массиве
int PositiveElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > 0) count++;
    return count;
}

// Подсчёт количества нечётных элементов в массиве
int NechetElement(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 != 0) count++;
    return count;
}

// Проверка является ли массив отсортированным по возрастанию. 
// Если массив отсортирован, то возвращать true, иначе - false.
bool SortArray(int[] array)
{
    for (int i = 1; i < array.Length; i++)
        if (array[i] < array[i - 1]) return false;
    return true;
}



Console.WriteLine("Размер массива: ");
int size = int.Parse(Console.ReadLine() ?? "0");
int[] array = new int[size];


FillArray(array, -30, 30);
Console.WriteLine("Массив: ");


PrintArray(array);
Console.WriteLine();

Console.WriteLine($"Минимальное значение: {MinValue(array)}");

Console.WriteLine($"Максимальное значение: {MaxValue(array)}");

Console.WriteLine($"Сумма элементов массива: {SumArray(array)}");

Console.WriteLine($"Произведение элементов массива: {MultiplicationArray(array)}");

Console.WriteLine("Введите искомый элемент  массива:  (ищем индекс)");
int N = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Заданный элемент массива соответсвует индексу {IndexElement(array, N)}");

Console.WriteLine("Проверим, есть ли число в массиве? Введите число: ");
int value = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"{ElementArray(array, value)}");

Console.WriteLine($"Среднее арифметическое элеметов массива: {MeanArray(array)}");

Console.WriteLine($"Кол-во отрицательных элементов в массиве: {NegativeElements(array)}");

Console.WriteLine("С Вас число - с меня кол-во вхождений числа в массив: ");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Заданное число встречается в массиве {Count(array, a)} раз/раза.");

Console.WriteLine($"Кол-во четных элементов в массиве: {ChetElement(array)}");

Console.WriteLine($"Кол-во положительных элементов в массиве: {PositiveElements(array)}" );

Console.WriteLine($"Кол-во нечетных элементов в массиве: {NechetElement(array)}");

Console.WriteLine("Отсортирован ли Ваш массив? ");
Console.WriteLine($"({SortArray(array)})");
