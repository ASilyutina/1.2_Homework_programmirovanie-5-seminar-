 //1.Функцию, которая вычисляет число a в степени n
 int Stepen(int st, int numb)
 {
     int count = 0;
     int NewNumber = 1;
     for (int i = 0; i < st; i++)
         if (count < st) NewNumber *= numb;
     count++;
     return NewNumber;
}


//2. Функцию, которая вычисляет факториал числа n
int Factorial(int N)
 {
     int F = 1;
     for (int i = 1; i <= N; i++)
         F *= i;
    return F;
 }

//3. Функцию, которая вычисляет сумму цифр произвольного целого числа n
int SumOfDigits(int K)
{
    int res = 0;
    foreach (char digit in K.ToString().ToCharArray())
        res += int.Parse(digit.ToString());
    return res;
}

//4. Функцию, которая проверяет является ли заданное число n полиндромом

bool IsPolindrom(int L)
{
    bool res = true;
    char[] digits = L.ToString().ToCharArray();
    for (int i = 0; i <= digits.Length / 2; i++)
        if (digits[i] != digits[digits.Length - 1 - i])
            res = false;
    return res;
}

//5. Функцию, складывающую два целых числа
int SumOfTwo(int first, int second)
{
    return first + second;
}


//6.Функцию, определяющую является ли число простым, то есть возвращающую true, если число простое, иначе - false.
bool IsSimple(int S)
{
    bool res = true;
    for (int i = 2; i <= S / 2; i++)
        if ((double)S / i == S / i)
            res = false;
    return res;
}

//7. Функцию, определяющую является ли число чётным, 
//то есть возвращающую true, если число чётное, иначе - false

 bool ChetNumber(int E)
 {
    if (E % 2 == 0) return true;
    return false;
}

Console.WriteLine("Введите число которое хотите возвести в степень: ");
int numb = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите степень в которую хотите возвести число: ");
int st = int.Parse(Console.ReadLine() ?? "0");
int stepen = Stepen(st, numb);
Console.WriteLine($"Возвдение числа {numb} в степень {st}: {stepen}");


Console.WriteLine("Введите число чтобы узнать его факториал: ");
int N = int.Parse(Console.ReadLine() ?? "0");
int F = Factorial(N);
Console.WriteLine($"Факториал числа {N} равен " + F);

Console.WriteLine("Введите число для получения суммы его цифр: ");
int K = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Сумма цифр числа {K}: {SumOfDigits(K)}");

Console.Write("Введите целое число чтобы узнать являетли ли оно полиндромом:   ");
int L = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Является ли число {L} полиндромом: {IsPolindrom(L)}");

Console.WriteLine("Введите первое число для сложения: ");
int num = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите второе число для сложения: ");
int sec = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Сумма чисел {num} и {sec}: {SumOfTwo(num, sec)}");

Console.WriteLine("Введите число для проверки на простоту: ");
int S = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Является ли число {S} простым: {IsSimple(S)}");

 Console.WriteLine("Введите число для его проверки на четность: ");
int E = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Число четное?  {ChetNumber(E)}");