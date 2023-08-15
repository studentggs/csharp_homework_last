//Задача 1

/* void ShowNums(int n)
{
    if (n != 1)
        ShowNums(n - 1);

    Console.Write(n + " ");
}

Console.Write("Input integer positive number: ");

int num = Convert.ToInt32(Console.ReadLine());

ShowNums(num); */


//Задача 2


/* int GetSumBetweenNandM(int m, int n)
{
    if (n > m)
        return n + GetSumBetweenNandM(m, n - 1);

    return m;
}

Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int result = GetSumBetweenNandM(m, n);

Console.WriteLine($"Сумма чисел от {m} до {n} равна {result}");*/

//Задача 3

/* Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

int akkerman(int m, int n)
{
if (m == 0) return n + 1;
else if (n == 0) return akkerman(m — 1, 1);
else return akkerman(m — 1, akkerman(m, n — 1));
}

Console.Write($"Функция Аккермана равно {akkerman(m, n)} ");*/

// Было приятно с Вами проходить этот курс. Мои благодарство!