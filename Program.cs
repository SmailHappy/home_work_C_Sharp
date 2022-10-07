﻿Run();

void Run() // Выбор задачи
{
    Console.Clear();
    Console.WriteLine("Д/з - 1. Задача 2 - 2. Задача 4 - 4. Задча 6 - 6. Задача 8 - 8.");
    Console.WriteLine("Д/з - 2. Задача 10 - 10. Задача 13 - 13. Задча 15 - 15.");
    Console.WriteLine("Д/з - 3. Задача 19 - 19. Задача 21 - 21. Задча 23 - 23. Задача * - 01. Задача ** - 02.");
    Console.WriteLine("Д/з - 4. Задача 25 - 25. Задача 27 - 27. Задча 29 - 29. Задача * - 03. Задача ** - 04.");
    Console.WriteLine("Д/з - 5. Задача 34 - 34. Задача 36 - 36. Задча 38 - 38. Задача * - 05. Задача ** - 06.");
    Console.WriteLine("\nДля выхода из программы - 0\n");
    Console.Write("Введите код задачи: ");
    int exempl = int.Parse(Console.ReadLine());

    if (exempl == 10) Exemple10();
    else if (exempl == 2) Exemple2();
    else if (exempl == 4) Exemple4();
    else if (exempl == 6) Exemple6();
    else if (exempl == 8) Exemple8();
    else if (exempl == 13) Exemple13();
    else if (exempl == 15) Exemple15();
    else if (exempl == 19) Exemple19();
    else if (exempl == 21) Exemple21();
    else if (exempl == 23) Exemple23();
    else if (exempl == 01) Exemple_1();
    else if (exempl == 02) Exemple_2();
    else if (exempl == 25) Exemple25();
    else if (exempl == 27) Exemple27();
    else if (exempl == 29) Exemple29();
    else if (exempl == 03) Exemple_3();
    else if (exempl == 04) Exemple_4();
    else if (exempl == 34) Exemple34();
    else if (exempl == 36) Exemple36();
    else if (exempl == 38) Exemple38();
    else if (exempl == 05) Exemple_5();
    else if (exempl == 06) Exemple_6();
    else if (exempl == 0)
    {
        Console.WriteLine("\nДля завершения программы нажмите Enter");
        Console.ReadLine();
    }
    else Console.WriteLine("Такой задачи здесь нету");
}

void Exemple2() // Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
{
    Console.Clear();
    Console.WriteLine("Задача 2. Поиск максимального из введённых чисел\n");
    Console.Write("Введите 1 число: ");
    int number_one = int.Parse(Console.ReadLine());

    Console.Write("Введите 2 число: ");
    int number_two = int.Parse(Console.ReadLine());

    if (number_one > number_two) Console.WriteLine($"Max = {number_one}");
    else if (number_two > number_one) Console.WriteLine($"Max = {number_two}");
    else Console.WriteLine($"Числа равны. Max = {number_one}");

    Break();
}

void Exemple4() // Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
{
    Console.Clear();
    Console.WriteLine("Задача 4. Поиск максимального из введённых чисел\n");
    Console.WriteLine("Введите 3 числа.");
    Console.Write("1 число: ");
    int number1 = int.Parse(Console.ReadLine());

    Console.Write("2 число: ");
    int number2 = int.Parse(Console.ReadLine());

    Console.Write("3 число: ");
    int number3 = int.Parse(Console.ReadLine());

    int max = number1;

    if (number2 >= max) max = number2;
    if (number3 >= max) max = number3;
    if (max == number2 & max == number3 & max == number1) Console.Write("Введённые числа равны. ");
    if ((number1 == number2  & max != number3) | 
        (number1 == number3  & max != number2) | 
        (number2 == number3  & max != number1))
    {
        Console.Write("Некоторые введённые числа равны. ");
    }

    Console.WriteLine($"Наибольшее число = {max}");
    Break();
}

void Exemple6() // Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
{
    Console.Clear();
    Console.WriteLine("Задача 6. Проверка является ли число чётным\n");
    Console.Write("Введите число: ");
    int number = int.Parse(Console.ReadLine());

    if (number == 0) Console.WriteLine("Вы указали 0. Попробуйте ввести другое число.");
    else if (number % 2 == 0) Console.WriteLine($"Число {number} - Является чётным");
    else Console.WriteLine($"Число {number} - Нечётное");
    
    Break();
}

void Exemple8() // Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
{
    Console.Clear();
    Console.WriteLine("Задача 8. Показывает все чётные числа от 1 до N\n");
    Console.Write("Введите число N: ");
    int numb = int.Parse(Console.ReadLine());
    int i = 2;

    if (numb < 2)
    {
        Console.WriteLine("В диапазоне нету чётных чисел. Поробуйте ввести другое число.");
    }

    while (i <= numb)
    {
        Console.Write($"{i} ");
        i += 2;
    }
    Break();
}

void Exemple10() // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
{
    Console.Clear();
    Console.WriteLine("Задача 10. Принимает 3х значное число и выводит 2ую цифру.\n");
    Console.Write("Введите число: ");
    int number = int.Parse(Console.ReadLine());

    if ((number > 0) & (number < 1000))
    {
        int devision = number / 10;
        devision = devision % 10;
        Console.WriteLine($"{devision} - Вторая цифра числа {number}.");
    }
    else
    {
        Console.WriteLine("Вы ввели не трёхзначное число.");
    }
    Break();
}

void Exemple13() // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
{
    Console.Clear();
    Console.WriteLine("Задача 13. Выводит 3 цифру заданного числа.\n");
    Console.Write("Введите число: ");
    int numb = int.Parse(Console.ReadLine());

    if (numb > 99)
    {
        string numbr = numb.ToString();
        Console.WriteLine($"{numbr[2]} - Третья цифра числа {numb}.");
    }
    else
    {
        Console.WriteLine($"Число {numb} не имеет 3 цифру.");
    }
    Break();
}
 
void Exemple15() // Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
{
    Console.Clear();
    Console.WriteLine("Задача 15. Принимает число обозначающий день недели. Проверяет ялвется ли оно выходным.\n");
    Console.Write("Введите число: ");
    int day = int.Parse(Console.ReadLine());

    if ((day > 0) & (day < 8))
    {
        if ((day == 6) | (day == 7))
        {
            Console.WriteLine("Да, это выходной день.");
        }
        else
        {
            Console.WriteLine("Нет. Это не выходной.");
        }
    }
    else
    {
        Console.WriteLine("Вы ввели не день недели.");
    }
    Break();
}

void Exemple19() // Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
{
    Console.Clear();
    Console.WriteLine("Задача 19. Проверка 5 значного числа на палиндром.\n");
    Console.Write("Введите число: ");
    int number = int.Parse(Console.ReadLine());
    string numbr = number.ToString();
    if (number > 10000 & number < 100000)
    {
        if (numbr[0] == numbr[4] & numbr[1] == numbr[3])
        {
            Console.WriteLine($"Число {number} является палиндромом\n");
        }
        else
        {
            Console.WriteLine($"Число {number} не палиндром\n");
        }
    }
    else
    {
        Console.WriteLine("Вы указали не 5 значное число.\n");
    }
    Break();
}

void Exemple21() // Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
{
    Console.Clear();
    Console.WriteLine("Задача 21. Нахождение расстояние между 2 точками в 3D пространстве.\n");
    Console.Write("Введите число ' x ' для точки А: ");
    int x1 = int.Parse(Console.ReadLine());
    Console.Write("Введите число ' y ' для точки А: ");
    int y1 = int.Parse(Console.ReadLine());
    Console.Write("Введите число ' z ' для точки А: ");
    int z1 = int.Parse(Console.ReadLine());
    Console.Write("Введите число ' x ' для точки B: ");
    int x2 = int.Parse(Console.ReadLine());
    Console.Write("Введите число ' y ' для точки B: ");
    int y2 = int.Parse(Console.ReadLine());
    Console.Write("Введите число ' z ' для точки B: ");
    int z2 = int.Parse(Console.ReadLine());

    // A (x1,y1,z1), B (x2,y2,z2)
    // Длина = √ (B - A)^2
    // Для удобства при работе в консоле

    Console.Clear();
    Console.WriteLine("Задача 21. Нахождение расстояние между 2 точками в 3D пространстве.\n");
    Console.WriteLine($"Точка A({x1},{y1},{z1}), Точка В({x2},{y2},{z2})");
    double distance = Math.Sqrt((Math.Pow((x2 - x1), 2)) + (Math.Pow((y2 - y1), 2)) + (Math.Pow((z2 - z1), 2)));
    Console.WriteLine($"\nРасстояние между точками A и В = {Math.Round(distance, 2)}\n");

    Break();
}

void Exemple23() // Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
{
    Console.Clear();
    Console.WriteLine("Задача 23. Принимает число N и выводит таблицу кубов чисел в диапазоне от 1 до N\n");
    Console.Write("Введите число N: ");
    int number = int.Parse(Console.ReadLine());

    if (number < 1)
    {
        Console.WriteLine("Вы ввели не корректное число.\n");
    }
    else
    {
        int step = 1;
        Console.Write($"Таблица кубов в диапазоне от 1 до {number}: ");
        while (step <= number)
        {
            if (step == number)
            {
                Console.Write(Math.Pow(step, 3)); // Для того чтобы после последнего числа не было ' , '
            }
            else
            {
                Console.Write(Math.Pow(step, 3) + ", ");
            }
            step += 1;
        } 
        Console.WriteLine("\n"); // Для удобства вывода в консоли
    }
    Break();
}

void Exemple_1() // Дополнительная задача (задача со звёздочкой): Напишите программу, которая на вход принимает радиус круга 
// и находит его площадь округленную до целого числа, необходимо вывести максимальную цифру в полученном округлённом значении площади круга.
// 10 -> 4
// 20 -> 7
// 30 -> 8
{
    Console.Clear();
    Console.WriteLine("Задача *. Принимает Радиус круга и выводит Максимальное число из его площади (округленную до целого)\n");
    Console.Write("Введите радиус круга: ");
    double radius = double.Parse(Console.ReadLine());

    // Площадь = pi*(r^2)

    double square = Math.Round(Math.PI * Math.Pow(radius, 2));
    Console.WriteLine($"Площадь круга = {square}\n");
    string sq = square.ToString();
    int square_number_max = 0;
    int index = 0;

    while (index < sq.Length)
    {
        int square_number = int.Parse(Convert.ToString(sq[index]));
        if (square_number_max < square_number)
        {
            square_number_max = square_number;
        }
        index += 1;
    }
    Console.WriteLine($"Наибольше число из площади круга = {square_number_max}");
    Break();
}

void Exemple_2() // Дополнительная задача 2 (задача со звёздочкой): Напишите программу, которая на вход принимает букву, 
// необходимо создать массив из 5 названий городов, и вывести на экран те (тот), где чаще всего встречается введённая буква.
// Введённая буква: "о", массив ("Москва", "Тюмень", "Новосибирск") -> "Новосибирск"
{
    Console.Clear();
    Console.WriteLine("Задача **. Принимает букву для поиска города (городов) в котором она встречается.\n");
    Console.Write("Введите букву: ");
    string? letter_to_search = Console.ReadLine();

    string[] massive_city = {"Москва", "Пенза", "Саратов", "Волгоград", "Астрахань", "Белгород", "Тула"};
    string city = ""; // Для вывода этого города
    int count_city = 0; // Для нахождения совпадений буквы с городом
    int count_max = 0; // Макс кол-во букв в городе

    for (int i = 0; i < massive_city.Length; i++)
    {
        string city_search = massive_city[i]; // Город из массива
        int count_city_search = 0; // Для определения кол-ва буквы (введённой) в городе

        for (int j = 0; j < city_search.Length; j++)
        {
            if (Convert.ToString(city_search[j]).ToLower() == letter_to_search.ToLower())
            {
                count_city_search += 1;
            }
        }
        if (count_city_search > count_max)
        {
            city = city_search;
            count_max = count_city_search;
            count_city = 1;
        }
        else if ((count_city_search == count_max) & (count_max > 0))
        {
            count_city += 1;
            city = city + ", " + city_search;
        }
    }
    if (count_city > 1)
    {
        Console.WriteLine("\nНесколько городов имеют одиннаковое колличество введенной буквы:");
        Console.WriteLine(city);
    }
    else if (count_city == 1)
    {
        Console.WriteLine("\nВ созданном массиве только 1 город с наибольшим кол-вом этой буквы:");
        Console.WriteLine(city);
    }
    else
    {
        Console.WriteLine("\nСовпадений с введённой буквой в созданном массиве нету.\nПопробуйте ввести другую букву.");
    }
    Console.WriteLine(""); // для консоли 
    Break();
}

void Exemple25() // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
{
    double double_pow(int number, int degree_number) // Для отрицательной степени
    {
        degree_number = Math.Abs(degree_number);
        int i = 1;
        double result = 1;
        while (i <= degree_number)
        {
            result = result * number;
            i += 1;
        }
        result = 1 / result;
        return result;
    }

    int pow(int number, int degree_number) // Цикл возведение числа в Степень
    {
        int result = 1;
        int i = 1;
        if (degree_number == 0)
        {
            result = 1;
        }
        else
        {
            while (i <= degree_number)
            {
                result = result * number;
                i += 1;
            }
        }
        return result;
    }

    Console.Clear();
    Console.WriteLine("Задача 25. Принимает 2 числа и возводит число A в степень числа B.\n");
    Console.Write("Введите число A: ");
    int number_A = int.Parse(Console.ReadLine());
    Console.Write("Введите число B: ");
    int number_B = int.Parse(Console.ReadLine());

    if (number_B < 0)
    {
        Console.WriteLine($"\nA в степени B = {double_pow(number_A, number_B)}\n");
    }
    else
    {
        Console.WriteLine($"\nA в степени B = {pow(number_A, number_B)}\n");
    }
    Break();
}

void Exemple27() // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
{
    int sum_in_number(int num) // Сумма всех цифр в числе 
    {
        string number = num.ToString();
        int result = 0;
        for (int i = 0; i < number.Length; i ++)
        {
            result = result + int.Parse(number[i].ToString());
        }
        return result;
    }

    Console.Clear();
    Console.WriteLine("Задача 27. Принимает число и выдаёт сумму цифр в этом числе.\n");
    Console.Write("Введите число: ");
    int number = int.Parse(Console.ReadLine());

    Console.WriteLine($"\nСумма цифр = {sum_in_number(number)}\n");
    Break();   
}

void Exemple29() // Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
{
    Console.Clear();
    Console.WriteLine("Задача 29. Выводит на экран массив из N элементов.\n");
    Console.Write("Введите число N: ");
    int number = int.Parse(Console.ReadLine());

    int[] array = new int[number];
    array = array_random(array);

    Console.Write($"\n[{String.Join(",",array)}]\n");
    Break();
}

void Exemple_3() // Дополнительная задача (задача со звёздочкой): Напишите программу, которая задаёт массив из 10 элементов,
// которые необходимо заполнить случайными значениями в диапазоне от -10 до 10 и найти максимальное значение среди них.
// [-1, 2, 4, 6, -7, 9, -3, -4, -6 ,1] -> 9
// [-5, 1, -9, 6, -7, -2, -3, -4, -6 ,1] -> 6
// [-7, 2, 4, 6, -7, 7, -3, -4, -2 ,1] -> 7 
{ 
    int max_in_array(int[] array) // Нахождение максимума в массиве
    {
        int max_in_array = array[0];
        for (int i = 0; i < array.Length; i ++)
        {
            if (max_in_array < array[i])
            {
                max_in_array = array[i];
            }
        }
        return max_in_array;
    }

    Console.Clear();
    Console.WriteLine("Задача *. Заполняет массив из 10 элементов в диапазоне (-10 : 10) и выводит максимальное число из массива.\n");

    int[] array = new int[10];
    array = array_random(array, -10, 10);

    Console.WriteLine($"Массив - [{String.Join(", ",array)}]");
    Console.WriteLine($"Максимальное число в массиве - {max_in_array(array)}\n");
    Break();    
}

void Exemple_4() // Дополнительная задача 2 (задача со звёздочкой): Напишите программу, которая задаёт 2 одномерных массива из N элементов
// которые заполняются случайными значениями в диапазоне от 1 до 10 и находит среднее арифметическое элементов этих 2 массивов, 
// далее от большего из получившихся средних арифметических отнимаем меньшее и округлённый до целого числа результат переводим в двоичную систему счисления.
// [1,2,3,4] [3,6,4] -> округлённая до целого числа разница между средними арифметическими массивов = 2. 2 в двоичной системе счисления = 10
// [4,7,9] [3,3,1,2,2] -> округлённая до целого числа разница между средними арифметическими массивов = 4. 4 в двоичной системе счисления = 100
{
    double average_array(int[] array) // Ср.Ариф. массива
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum = sum + array[i];
        }
        return sum / array.Length;
    }

    string from10_in2(int number)// Перевод из 10ой в 2ую систему исчисления
    {
        string result = "";
        if (number == 1)
        {
            return "01";
        }
        else if (number == 0)
        {
            return "00";
        }
        while (number != 1)
        {
            if (number % 2 == 1)
            {
                result = "1" + result;
                number = (number - 1) / 2;
            }
            else if (number % 2 == 0)
            {
                result = "0" + result;
                number = number / 2;
            }
        }
        if (number == 0)
        {
            result = "0" + result;
        }
        else if (number == 1)
        {
            result = "1" + result;
        }
        return result;
    }

    Console.Clear();
    Console.WriteLine("Задача **. Заполняет 2 одномернных массива из N элементов в диапазоне (1 : 10), находит разницу между средними арифметическими (округленную до целого) и выводит результат в 2ой системе.\n");
    Console.Write("Введите число N: ");
    int number = int.Parse(Console.ReadLine());

    int[] array_one = new int[number];
    array_one = array_random(array_one, 1, 10);
    int[] array_two = new int[number];
    array_two = array_random(array_two, 1, 2);

    Console.WriteLine($"Массив 1 - [{String.Join(", ",array_one)}]");
    Console.WriteLine($"Массив 2 - [{String.Join(", ",array_two)}]\n");

    double average_one = average_array(array_one);
    double average_two = average_array(array_two);
    int average = 0;

    // Console.Write(average_array(array_one));
    // Console.WriteLine($"\t{average_array(array_two)}\n");

    if (average_one > average_two)
    {
        average = Convert.ToInt32(Math.Round(average_one - average_two));
    }
    else
    {
        average = Convert.ToInt32(Math.Round(average_two - average_one));
    }

    Console.WriteLine($"Разница между ср.ар. массивов = {average}\nВ 2ой системе исчисления - {from10_in2(average)}\n");
    Break();   
}

void Exemple34() // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
{
    int search_positive_number(int[] array)
    {
        int count = 0;

        for (int i = 0; i < array.Length; i ++)
        {
            if (array[i] % 2 == 0)
            {
                count += 1;
            }
        }
        return count;
    }

    Console.Clear();
    Console.WriteLine("Задача 34. Показывает колличество четных 3 значных чисел в случайно заполненном массиве.\n");

    int[] array = new int[5];
    array = array_random(array, 100, 1000);

    Console.WriteLine($"Массив - [{String.Join(", ",array)}]");
    Console.WriteLine($"Колличество четных чисел в массиве - {search_positive_number(array)}\n");

    Break();
}

void Exemple36() // Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
{
    int sum_in_array(int[] array) 
    {
        int sum = 0;

        for (int i = 1; i < array.Length; i += 2)
        {
            sum = sum + array[i];
        }
        return sum;
    }

    Console.Clear();
    Console.WriteLine("Задача 36. Показывает сумму элементов, находящихся на нечётных позициях.\n");

    int[] array = new int[5];
    array = array_random(array, -10, 10);

    Console.WriteLine($"Массив - [{String.Join(", ",array)}]");
    Console.WriteLine($"\nСумма цифр нечётных позиций = {sum_in_array(array)}\n");

    Break();   
}

void Exemple38() // Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
{
    int max_in_array(int[] array)
    {
        int max_in_array = array[0];

        for (int i = 0; i < array.Length; i ++)
        {
            if (max_in_array < array[i])
            {
                max_in_array = array[i];
            }
        }
        return max_in_array;
    }

    int min_in_array(int[] array)
    {
        int min_in_array = array[0];
        for (int i = 0; i < array.Length; i ++)
        {
            if (min_in_array > array[i])
            {
                min_in_array = array[i];
            }
        }
        return min_in_array;
    }

    Console.Clear();
    Console.WriteLine("Задача 38. Находит разницу между максимальным и минимальным элементом массива.\n");

    int[] array = new int[8];
    array = array_random(array);
    int diff = max_in_array(array) - min_in_array(array);

    Console.Write($"\n[{String.Join(",",array)}]\n");
    Console.WriteLine($"Разница между макс({max_in_array(array)}) и мин({min_in_array(array)}) элементами = {diff}\n");

    Break();
}

void Exemple_5() // Дополнительная задача (задача со звёздочкой): Задайте одномерный массив, заполненный случайными числами.
// Из входного массива сформируйте массив с чётными и массив с нечётными значениями элементов входного массива. 
// Найдите ср. арифметическое из полученных значений эл массивов и выведите результат сравнения средних арифметических.
// [1,2,3,4] -> ср. арифм. знач эл массива с чётными числами > ср. арифм. знач эл с нечётными числами
// [2,3,5,7] -> ср. арифм. массива знач эл с нечётными числами > ср. арифм. знач эл с чётными числами
// [1,2,5,4] -> ср. арифм. знач эл массива с нечётными числами = ср. арифм. знач эл с чётными числами
{
    int[] negative_number_array(int[] array)
    {
        int j = 0;
        int[] negative_number_array = new int[array.Length];

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 1)
            {
                negative_number_array[j] = array[i];
                j += 1;
            }
        }

        int[] negative_array = new int[j];
        
        for (int i = 0; i < j; i++)
        {
            negative_array[i] = negative_number_array[i];
        }

        return negative_array;
    }

    int[] positive_number_array(int[] array)
    {
        int j = 0;
        int[] positive_number_array = new int[array.Length];

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                positive_number_array[j] = array[i];
                j += 1;
            }
        }

        int[] positive_array = new int[j];
        
        for (int i = 0; i < j; i++)
        {
            positive_array[i] = positive_number_array[i];
        }

        return positive_array;
    }

    double average_array(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum = sum + array[i];
        }
        return sum / array.Length;
    }

    Console.Clear();
    Console.WriteLine("Задача *. Сравнивает среднее арифметическое 2х массивов (четный и нечётный) созданные из 1 случайного массива.\n");

    int[] array = new int[6];
    array = array_random(array, 1, 10);

    Console.WriteLine($"Массив - [{String.Join(", ",array)}]");

    /*Console.Write($"Массив чётных - [{String.Join(", ",positive_number_array(array))}]. ");
    Console.Write($"Среднее арифметическое - {average_array(positive_number_array(array))}\n");
    Console.Write($"Массив нечётных - [{String.Join(", ",negative_number_array(array))}]. ");
    Console.Write($"Среднее арифметическое - {average_array(negative_number_array(array))}\n");*/

    if (average_array(positive_number_array(array)) > average_array(negative_number_array(array)))
    {
        Console.WriteLine("Среднее арифметическое Чётных чисел в массиве ' > ' среднего арифметического Нечётных чисел \n");
    }
    else if (average_array(positive_number_array(array)) < average_array(negative_number_array(array)))
    {
        Console.WriteLine("Среднее арифметическое Чётных чисел в массиве ' < ' среднего арифметического Нечётных чисел \n");
    }
    else if (average_array(positive_number_array(array)) == average_array(negative_number_array(array)))
    {
        Console.WriteLine("Среднее арифметическое Чётных чисел в массиве ' = ' среднего арифметического Нечётных чисел \n");
    }

    Break();    
}

void Exemple_6() // Дополнительная задача 2 (задача со звёздочкой): Задайте одномерный массив из N элементов, заполненный случайными числами.
// Необходимо определить, в какой последовательности заданы элементы массива: по возрастанию, по убыванию, хаотично, или все элементы одинаковы.
// [1,2,3,4] -> по возрастанию
// [4,3,2,1] -> по убыванию
// [4,2,3,1] -> хаотично
// [1,1,1,1] -> все элементы равны
{
    bool ascending(int[] array)
    {
        int number_array = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > number_array)
            {
                number_array = array[i];
            }
            else
            {
                return false;
            }
        }

        return true;

    }

    bool descending(int[] array)
    {
        int number_array = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < number_array)
            {
                number_array = array[i];
            }
            else
            {
                return false;
            }
        }

        return true;

    }

    bool equal(int[] array)
    {
        int number_array = array[0];

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != number_array)
            {
                return false;
            }
        }

        return true;

    }

    bool chaotic(int[] array)
    {
        if ((((ascending(array) == false)) & (descending(array) == false)) & (equal(array) == false))
        {
            return true;
        }

        return false;

    }

    Console.Clear();
    Console.WriteLine("Задача **. Определяет в какой последовательности заданы элементы в массиве из N элементов.\n");
    Console.Write("Введите число N: ");
    int number = int.Parse(Console.ReadLine());

    int[] array = new int[number];
    array = array_random(array, 1, 5);

    Console.WriteLine($"Массив - [{String.Join(", ",array)}]");

    if (chaotic(array) == false)
    {
        if (equal(array) == true)
        {
            Console.WriteLine($"Элементы в массиве одиннаковые\n");
        }
        else if (descending(array) == true)
        {
            Console.WriteLine($"Элементы в массиве расположены по убыванию\n");
        }
        else if (ascending(array) == true)
        {
            Console.WriteLine($"Элементы в массиве расположены по возрастанию\n");
        }
    }
    else
    {
        Console.WriteLine($"Элементы в массиве расположены хаотично\n");
    }

    Break();   
}

int[] array_random(int[] array, int from = 0, int to = 100) // Заполнение массива случайными числами
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(from, to);
    }

    return array;
}

void Break() // Завершение програграммы
{
    Console.WriteLine("\nДля выбора Другой задачи введите 5.     Для выхода из программы 0\n");
    int ret = int.Parse(Console.ReadLine());

    if (ret == 5) Run();
    else 
    {
        Console.Clear();
        Console.WriteLine("Для завершения программы Enter");
        Console.ReadLine();
    }
}