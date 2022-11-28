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
        return degree + ", "; F
    }

    int a = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i <= a; i++)
    {
        Console.Write(NumberToThridDegree(i, a));
    }
}





