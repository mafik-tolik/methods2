Console.Clear();


//Fiska01();

void Fiska01()
{
    String txt = "456";
    int digit = txt[2] - '0'; // без <- '0'> выведет из таблицы элементов номер элемента цифры 6. Чтобы вывело цифру 6, нужно использовать <- '0'>.
    Console.WriteLine(digit);
    Console.WriteLine(txt[2]);
}


// Fiska02();

void Fiska02()
{
    double DistanceBetweenTwoPoint((double x, double y, double z) point1, (double x, double y, double z) point2) // метод вычисления по теореме Пифагора, но он неправильный. 
    // в аргументах мы используем картежи. Картежи объединяет несколько переменных внутри себя (до 8 переменных, которые хотим объединить в картеж). 
    {
        return Math.Sqrt(Math.Pow((point2.x - point1.x), 2)
                        + Math.Pow((point2.y - point1.y), 2)
                        + Math.Pow((point2.z - point1.z), 2));
    }

    (double x, double y, double z) GetPointCoord() // метод ввода трех переменных через картеж. 
    {
        (double x, double y, double z) point;
        Console.Write("x= ");
        point.x = Convert.ToDouble(Console.ReadLine());
        Console.Write("y= ");
        point.y = Convert.ToDouble(Console.ReadLine());
        Console.Write("z= ");
        point.z = Convert.ToDouble(Console.ReadLine());

        return point;
    }


    (double x, double y, double z) point1 = GetPointCoord();
    (double x, double y, double z) point2 = GetPointCoord();

    double answer = DistanceBetweenTwoPoint(point1, point2);
    Console.WriteLine(answer);
}


// Fiska03();

void Fiska03()
{
    string NumberToThridDegree(int number, int LastNumber)
    {
        string degree = Math.Pow(number, 3).ToString();
        if (number == LastNumber)
            return degree;
        return degree + ", ";
    }

    int a = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i <= a; i++)
    {
        Console.Write(NumberToThridDegree(i, a));
    }
}


// Ex31();
// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

void Ex31()
{
    int size = ReadIntFromConsole("Введите размер массива: ");

    int[] array = new int[size];

    FillIntArray(array, -9, 10);
    PrintIntArray(array);

    int[] massiv = SumPositivAndSumNegative(array);

    Console.WriteLine($"Cумма положительных чисел: {massiv[0]}\nCумма отрицательных чисел: {massiv[1]}");
}


// Ex32();
// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

void Ex32()
{
    int size = ReadIntFromConsole("Введите размер массива: ");

    int[] array = new int[size];

    FillIntArray(array, -9, 10);
    PrintIntArray(array);

    IsNegativeForPositive(array);
    PrintIntArray(array);
}



// Ex33();
// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// массив [6, 7, 19, 345, 3] -> нет
// массив [6, 7, 19, 345, 3] -> да

void Ex33()
{
    int size = ReadIntFromConsole("Введите размер массива: ");
    int[] array = new int[size];

    FillIntArray(array, -9, 10);
    PrintIntArray(array);

    int number = ReadIntFromConsole("Введите число, которое нужно найти: ");

    FindNumber(array, number);
}







int ReadIntFromConsole(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillIntArray(int[] arr, int minVal = -99, int maxVal = 99)
{
    maxVal++;
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minVal, maxVal);
    }
}

void PrintIntArray(int[] arr)
{
    Console.Write($"Вывод массива: [");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write("\b\b]\n");
}

int[] SumPositivAndSumNegative(int[] arr)
{
    int[] mass = new int[2];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) mass[0] += arr[i];
        else if (arr[i] < 0) mass[1] += arr[i];
    }
    return mass;
}

void IsNegativeForPositive(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = -arr[i];
    }
}

void FindNumber(int[] arr, int find)
{
    bool flag = false;
    int i = 0;
    while (!flag && i < arr.Length)
    {
        if (arr[i] == find)
        {
            flag = true;
        }
        i++;
    }
    if (flag) Console.WriteLine($"Число {find} есть в массиве");
    else Console.WriteLine($"Числа {find} нет в массиве");
}
