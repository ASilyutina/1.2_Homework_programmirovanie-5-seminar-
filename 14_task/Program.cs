//14.Проверка является ли массив отсортированным по возрастанию. 
//Если массив отсортирован, то возвращать true, иначе - false.

 static bool IsArraySortedAscending(int[] array)
        {
            bool sortedAscending = true;
 
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[i - 1])
                {
                    sortedAscending = false;
 
                    break;
                }
            }
 
            return sortedAscending;
        }
 
        static bool IsArraySortedDescending(int[] array) 
        {
            bool sortedAscending = true;
 
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[i - 1])
                {
                    sortedAscending = false;
 
                    break;
                }
            }
 
            return sortedAscending;
        }
 
       // static void Main(string[] args)
        {
            Console.WriteLine("Массив чисел от 1 до 21 ");
 
            int[] array = new int[21];
 
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
                Console.Write(" " + array[i]);
            }
 
            Console.WriteLine(Environment.NewLine + "Массив отсортирован по возрастанию? = " + IsArraySortedAscending(array));
            Console.WriteLine("Массив отсортирован по убыванию? = " + IsArraySortedDescending(array));
 
            Console.WriteLine(Environment.NewLine + "Массив чисел от 21 до 1 ");
 
            int[] array1 = new int[21];
 
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = array1.Length - i;
                Console.Write(" " + array1[i]);
            }
 
            Console.WriteLine(Environment.NewLine + "Массив отсортирован по возрастанию? = " + IsArraySortedAscending(array1));
            Console.WriteLine("Массив отсортирован по убыванию? = " + IsArraySortedDescending(array1));
 
            Console.WriteLine(Environment.NewLine + "Массив случайных чисел от 1 до 21 ");
 
            int[] array2 = new int[21];
            Random random = new Random();
 
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = random.Next(1, 21);
 
                Console.Write(" " + array2[i]);
            }
 
            Console.WriteLine(Environment.NewLine + "Массив отсортирован по возрастанию? = " + IsArraySortedAscending(array2));
            Console.WriteLine("Массив отсортирован по убыванию? = " + IsArraySortedDescending(array2));
 
            Console.ReadKey();
        }