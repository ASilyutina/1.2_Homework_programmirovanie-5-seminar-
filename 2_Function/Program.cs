 //1.Функцию, которая вычисляет число a в степени n

Console.WriteLine("Введите число которое хотите возвести в степень: ");
double N = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень в которую хотите возвести число: ");
double S = int.Parse(Console.ReadLine());
double Result = Math.Pow(N,S);
Console.WriteLine($"1.Результат: {Result} ");


//2. Функцию, которая вычисляет факториал числа n
static int fact(int n)
{
      int result2;
      result2=1;
      for(int i=1; i<=n; i++)
      result2*=i;
  
return result2;
}
Console.WriteLine("Введите число : ");
int k = int.Parse(Console.ReadLine());
if (k==0)
System.Console.WriteLine(" Факториал числа {0}!={1}", k, fact(k));
else

{
    System.Console.WriteLine("{0}!=1", k);
    for(int i=1; i<k; i++)
    System.Console.Write("{0}*",i);
    System.Console.WriteLine("2.Факториал числа {0}! ={1}", k, fact(k));
}


//3. Функцию, которая вычисляет сумму цифр произвольного целого числа n

int number2 = new Random().Next(1, 100000);
int sumDigit = 0;
System.Console.Write($"3.Сумма цифр числа {number2} равна ");

while (number2 > 0)
{
    int digit = number2 % 10;
    sumDigit = sumDigit + digit;
    number2 = number2 / 10;
}

System.Console.WriteLine(sumDigit);

//4. Функцию, которая проверяет является ли заданное число n полиндромом


System.Console.Write("Введите целое число:   ");
string number = Console.ReadLine();
int length = number.Length;
string txtToCheck = number.Replace(" ","");  /// для проверки текста на палиндром

bool IsPalindrome()
{
    for (int i = 0; i < length / 2; i++)
        while (number[i] == number[length - 1])
        {
            return true;
        }
    return false;
}

if (IsPalindrome()) System.Console.WriteLine($"4. Введное число - {number} - является палиндромом");
else System.Console.WriteLine($"4. Число {number} не является палиндромом");
System.Console.WriteLine();

//5. Функцию, складывающую два целых числа

System.Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int sum = num1+num2;
Console.WriteLine($"5.Результат сложения двух целых чисел: {sum} ");

//6. Функцию, определяющую является ли число простым, то есть возвращающую true, если число простое, иначе - false
//7. Функцию, определяющую является ли число чётным, то есть возвращающую true, если число чётное, иначе - false