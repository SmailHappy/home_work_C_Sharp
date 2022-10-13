Run();

void Run() // Выбор задачи
{
    Console.Clear();
    Console.WriteLine("Д/з - 1. Задача 2 - 2. Задача 4 - 4. Задча 6 - 6. Задача 8 - 8.\n"
                    + "Д/з - 2. Задача 10 - 10. Задача 13 - 13. Задча 15 - 15.\n"
                    + "Д/з - 3. Задача 19 - 19. Задача 21 - 21. Задча 23 - 23. Задача * - 01. Задача ** - 02.\n"
                    + "Д/з - 4. Задача 25 - 25. Задача 27 - 27. Задча 29 - 29. Задача * - 03. Задача ** - 04.\n"
                    + "Д/з - 5. Задача 34 - 34. Задача 36 - 36. Задча 38 - 38. Задача * - 05. Задача ** - 06.\n"
                    + "Д/з - 6. Задача 41 - 41. Задача 43 - 43. Задача * - 07. Задача ** - 08.\n"
                    + "Д/з - 7. Задача 47 - 47. Задача 50 - 50. Задача 52 - 52. Задача * - 09. Задача ** - 010.\n"
                    + "Д/з - 8. Задача 54 - 54. Задача 56 - 56. Задача 58 - 58. Задача * - 011. Задача ** - 012.\n");
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
    else if (exempl == 41) Exemple41();
    else if (exempl == 43) Exemple43();
    else if (exempl == 07) Exemple_7();
    else if (exempl == 08) Exemple_8();
    else if (exempl == 47) Exemple47();
    else if (exempl == 50) Exemple50();
    else if (exempl == 52) Exemple52();
    else if (exempl == 09) Exemple_9();
    else if (exempl == 010) Exemple_10();
    else if (exempl == 54) Exemple54();
    else if (exempl == 56) Exemple56();
    else if (exempl == 58) Exemple58();
    else if (exempl == 011) Exemple_11();
    else if (exempl == 012) Exemple_12();
    else {
        Console.WriteLine("\nТакой задачи здесь нету");
        Break();
    }
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
    int N = int.Parse(Console.ReadLine());

    int[] array = fill_array_ONE_dimensional(N);

    Console.Write($"\n[{String.Join(",",array)}]\n");
    Break();
}

void Exemple_3() // Дополнительная задача (задача со звёздочкой): Напишите программу, которая задаёт массив из 10 элементов,
// которые необходимо заполнить случайными значениями в диапазоне от -10 до 10 и найти максимальное значение среди них.
// [-1, 2, 4, 6, -7, 9, -3, -4, -6 ,1] -> 9
// [-5, 1, -9, 6, -7, -2, -3, -4, -6 ,1] -> 6
// [-7, 2, 4, 6, -7, 7, -3, -4, -2 ,1] -> 7 
{ 
    int max_in_array(int[] input_array) // Нахождение максимума в массиве
    {
        int max_in_array = input_array[0];
        for (int i = 0; i < input_array.Length; i ++)
        {
            if (max_in_array < input_array[i])
            {
                max_in_array = input_array[i];
            }
        }
        return max_in_array;
    }

    Console.Clear();
    Console.WriteLine("Задача *. Заполняет массив из 10 элементов в диапазоне (-10 : 10) и выводит максимальное число из массива.\n");

    int[] array = fill_array_ONE_dimensional(10, -10, 10);

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
    double average_array(int[] input_array) // Ср.Ариф. массива
    {
        int sum = 0;
        for (int i = 0; i < input_array.Length; i++)
        {
            sum = sum + input_array[i];
        }
        return sum / input_array.Length;
    }

    string from10_in2(int number)// Перевод из 10ой в 2ую систему исчисления
    {
        string result = "";
        if (number == 1) return "01";
        else if (number == 0) return "00";
        while (number != 1) {
            if (number % 2 == 1) {
                result = "1" + result;
                number = (number - 1) / 2;
            }
            else if (number % 2 == 0) {
                result = "0" + result;
                number = number / 2;
            }
        }
        if (number == 0) result = "0" + result;
        else if (number == 1) result = "1" + result;
        return result;
    }

    Console.Clear();
    Console.WriteLine("Задача **. Заполняет 2 одномернных массива из N элементов в диапазоне (1 : 10), находит разницу между средними арифметическими (округленную до целого) и выводит результат в 2ой системе.\n");
    Console.Write("Введите число N: ");
    int N = int.Parse(Console.ReadLine());

    int[] array_one = fill_array_ONE_dimensional(N, 1, 10);
    int[] array_two = fill_array_ONE_dimensional(N, 1, 2);

    Console.WriteLine($"Массив 1 - [{String.Join(", ",array_one)}]");
    Console.WriteLine($"Массив 2 - [{String.Join(", ",array_two)}]\n");

    double average_one = average_array(array_one);
    double average_two = average_array(array_two);
    int average = 0;

    if (average_one > average_two) average = Convert.ToInt32(Math.Round(average_one - average_two));
    else average = Convert.ToInt32(Math.Round(average_two - average_one));

    Console.WriteLine($"Разница между ср.ар. массивов = {average}\nВ 2ой системе исчисления - {from10_in2(average)}\n");
    Break();   
}

void Exemple34() // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
{
    int search_positive_number(int[] input_array) {
        int count = 0;

        for (int i = 0; i < input_array.Length; i ++) {
            if (input_array[i] % 2 == 0) count += 1;
        }
        return count;
    }

    Console.Clear();
    Console.WriteLine("Задача 34. Показывает колличество четных 3 значных чисел в случайно заполненном массиве.\n");

    int[] array = fill_array_ONE_dimensional(5, 100, 1000);

    Console.WriteLine($"Массив - [{String.Join(", ",array)}]");
    Console.WriteLine($"Колличество четных чисел в массиве - {search_positive_number(array)}\n");

    Break();
}

void Exemple36() // Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
{
    int sum_in_array(int[] input_array) {
        int sum = 0;

        for (int i = 1; i < array.Length; i += 2) {
            sum = sum + array[i];
        }
        return sum;
    }

    Console.Clear();
    Console.WriteLine("Задача 36. Показывает сумму элементов, находящихся на нечётных позициях.\n");

    int[] array = fill_array_ONE_dimensional(5, -10, 10);

    Console.WriteLine($"Массив - [{String.Join(", ",array)}]");
    Console.WriteLine($"\nСумма цифр нечётных позиций = {sum_in_array(array)}\n");

    Break();   
}

void Exemple38() // Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
{
    int max_in_array(int[] input_array) {
        int max_in_array = input_array[0];

        for (int i = 0; i < input_array.Length; i ++) {
            if (max_in_array < input_array[i]) max_in_array = input_array[i];
        }
        return max_in_array;
    }

    int min_in_array(int[] input_array) {
        int min_in_array = input_array[0];

        for (int i = 0; i < input_array.Length; i ++) {
            if (min_in_array > input_array[i]) min_in_array = input_array[i];
        }
        return min_in_array;
    }

    Console.Clear();
    Console.WriteLine("Задача 38. Находит разницу между максимальным и минимальным элементом массива.\n");

    int[] array = fill_array_ONE_dimensional(8);
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
    int[] negative_number_array(int[] input_array) {
        int j = 0;
        int[] negative_number_array = new int[input_array.Length];

        for (int i = 0; i < input_array.Length; i++) {
            if (input_array[i] % 2 == 1) {
                negative_number_array[j] = input_array[i];
                j += 1;
            }
        }

        int[] negative_array = new int[j];
        
        for (int i = 0; i < j; i++) {
            negative_array[i] = negative_number_array[i];
        }

        return negative_array;
    }

    int[] positive_number_array(int[] input_array)
    {
        int j = 0;
        int[] positive_number_array = new int[input_array.Length];

        for (int i = 0; i < input_array.Length; i++) {
            if (input_array[i] % 2 == 0) {
                positive_number_array[j] = input_array[i];
                j += 1;
            }
        }

        int[] positive_array = new int[j];
        
        for (int i = 0; i < j; i++) {
            positive_array[i] = positive_number_array[i];
        }

        return positive_array;
    }

    double average_array(int[] input_array) {
        int sum = 0;
        for (int i = 0; i < input_array.Length; i++) {
            sum = sum + input_array[i];
        }
        return sum / input_array.Length;
    }

    Console.Clear();
    Console.WriteLine("Задача *. Сравнивает среднее арифметическое 2х массивов (четный и нечётный) созданные из 1 случайного массива.\n");

    int[] array = fill_array_ONE_dimensional(6, 1, 10);

    Console.WriteLine($"Массив - [{String.Join(", ",array)}]");

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
    bool ascending(int[] input_array) {
        int number_array = input_array[0];

        for (int i = 1; i < input_array.Length; i++) {
            if (input_array[i] > number_array) number_array = input_array[i];
            else return false;
        }

        return true;
    }

    bool descending(int[] input_array)
    {
        int number_array = input_array[0];

        for (int i = 1; i < input_array.Length; i++) {
            if (input_array[i] < number_array) number_array = input_array[i];
            else return false;
        }

        return true;
    }

    bool equal(int[] input_array)
    {
        int number_array = input_array[0];

        for (int i = 0; i < input_array.Length; i++) {
            if (input_array[i] != number_array) return false;
        }

        return true;
    }

    bool chaotic(int[] input_array) {
        if ((((ascending(input_array) == false)) & 
            (descending(input_array) == false)) & 
            (equal(input_array) == false)) return true;

        return false;
    }

    Console.Clear();
    Console.WriteLine("Задача **. Определяет в какой последовательности заданы элементы в массиве из N элементов.\n");
    Console.Write("Введите число N: ");
    int N = int.Parse(Console.ReadLine());

    int[] array = fill_array_ONE_dimensional(N, 1, 5);

    Console.WriteLine($"Массив - [{String.Join(", ",array)}]");

    if (chaotic(array) == false) {
        if (equal(array) == true) Console.WriteLine($"Элементы в массиве одиннаковые\n");
        else if (descending(array) == true) Console.WriteLine($"Элементы в массиве расположены по убыванию\n");
        else if (ascending(array) == true) Console.WriteLine($"Элементы в массиве расположены по возрастанию\n");
    }
    else Console.WriteLine($"Элементы в массиве расположены хаотично\n");

    Break();   
}

void Exemple41() // Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
{
    Console.Clear();
    Console.WriteLine("Задача 41. Показывает количество чисел больше 0 из M чисел.\n");
    Console.Write("Укажите количество чисел M: ");
    int M = int.Parse(Console.ReadLine());

    int[] array_numbers = new int[M];
    int count = 0;

    for (int i = 0; i < M; i++) {
        Console.Write("Введите {0}-ое число: ", i + 1);
        array_numbers[i] = int.Parse(Console.ReadLine());
        if (array_numbers[i] > 0) count += 1;
    }

    Console.WriteLine($"\nКолличество чисел больше 0 = {count}\n");

    Break();
}

void Exemple43() // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// b2 = b1 and k2 = k1 and y = b1 + k1 x
// k2<k1 and x = (b2 - b1)/(k1 - k2) and y = (b2 k1 - b1 k2)/(k1 - k2)
// k2>k1 and x = (b2 - b1)/(k1 - k2) and y = (b2 k1 - b1 k2)/(k1 - k2)
{
    Console.Clear();
    Console.WriteLine("Задача 43. Находит точку пересечения 2-х заданных прямых через уравнения y=k1*x+b1, y=k2*x+b2.\n");
    Console.WriteLine("Для определения прямых. Введите 2-е точки для каждой из прямой.");
    Console.Write("Введите угловой коэффициент для прямой A.\nk1 = ");
    double k1 = double.Parse(Console.ReadLine());
    Console.Write("Введите точку на оси ' y ' для прямой A.\nb1 = ");
    double b1 = double.Parse(Console.ReadLine());
    Console.Write("Введите угловой коэффициент для прямой B.\nk2 = ");
    double k2 = double.Parse(Console.ReadLine());
    Console.Write("Введите точку на оси ' y ' для прямой B.\nb2 = ");
    double b2 = double.Parse(Console.ReadLine());

    double x = 0;
    double y = 0;

    if (k1 == k2) Console.WriteLine("Прямые параллельные и не пересекаются");
    else {
        x = (b1 - b2) / (k2 - k1);
        y = k1 * x + b1;
        Console.WriteLine($"Точка пересечения = ({x}; {y})");
    }

    Break();
}

void Exemple_7() // Дополнительная задача (задача со звёздочкой): Напишите программу, 
// которая задаёт массив из n элементов, которые необходимо заполнить случайными значениями 
// и сдвинуть элементы массива влево, или вправо на 1 позицию.
// [8, 5, 1, 7, 0] - [5, 1, 7, 0, 8] - сдвиг влево
// [8, 5, 1, 7, 0] - [0, 8, 5, 1, 7] - сдвиг вправо
{
    int[] left_shift(int[] input_array) {
        int first_number = input_array[0];

        for (int i = 0; i < input_array.Length - 1; i++) {
            input_array[i] = input_array[i + 1];
        }

        input_array[input_array.Length - 1] = first_number;
        return input_array;
    }

    int[] right_shift(int[] input_array) {
        int last_number = input_array[input_array.Length - 1];

        for (int i = input_array.Length - 1; i > 0; i--) {
            input_array[i] = input_array[i - 1];
        }

        input_array[0] = last_number;
        return input_array;
    }

    void shift(int[] input_array) {
        Console.Write("\nВ какую сторону сдвинуть массив?\nL (Влево) | R (Вправо)\t");
        string side = Convert.ToString(Console.ReadLine()).ToLower();

        if (side == "l") {
            Console.Write("\nСдвинули массив на 1 позицию влево: ");
            print_array_ONE_dimensional(left_shift(input_array)); 
        }
        else if (side == "r") {
            Console.Write("\nСдвинули массив на 1 позицию вправо: ");
            print_array_ONE_dimensional(right_shift(input_array)); 
        }
        else {
            Console.WriteLine("\nВ эту сторону сдвинуть невозможно.");
        }
    }

    Console.Clear();
    Console.WriteLine("Задача *. Заполняет массив из N элементов случайными числами "
        + "и сдвигает элемент на 1 позицию влево или вправо.\n");
    Console.Write("Введите число N: ");
    int N = int.Parse(Console.ReadLine());    

    int[] array = new int[N];
    array = fill_array_ONE_dimensional(N);
    print_array_ONE_dimensional(array);

    shift(array);

    Break();
}

void Exemple_8() // Дополнительная задача 2 (задача со звёздочкой): Напишите программу, 
// которая задаёт массив из n элементов, которые необходимо заполнить случайными значениями 
// и определить существует ли пара соседних элементов с одинаковыми значениями, 
// при наличии такого элемента заменить его на уникакальное значение.
// [1,2,3,3] -> [1,2,3,4]
{
    void search_equal_number(int[] input_array) {
        int new_number = 1;
        int count = 0;

        for (int i = 0; i < input_array.Length - 1; i++) {
            if (input_array[i] == input_array[i + 1]) {
                for (int j = 0; j < input_array.Length; j++) {
                    if (new_number == input_array[j]) {
                        new_number += 1;
                        j = -1;
                    }
                }
                Console.WriteLine($"Найдены соседние элементы на позициях {i + 1} и {i + 2}");
                input_array[i + 1] = new_number;
                Console.WriteLine($"Новое значение {i + 2}-ого элемента = {new_number}");
                count += 1;
            }
        }

        if (count > 0) print_array_ONE_dimensional(input_array);
        else Console.WriteLine("Соседних одиннаковых значений не найдено.");
    }

    Console.Clear();
    Console.WriteLine("Задача **. Проверяет соседние числа в массиве из N элементов.\n"
        + "Если они совпадают, заменяет второе из них на уникальное значение.\n");
    Console.Write("Введите число N: ");
    int N = int.Parse(Console.ReadLine()); 

    int[] array = new int[N];
    array = fill_array_ONE_dimensional(N);
    print_array_ONE_dimensional(array);

    search_equal_number(array);

    Break();
}

void Exemple47() // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
{
    Console.Clear();
    Console.WriteLine("Задача 47. Заполняет массив размером M * N случайными вещественными числами.\n");
    Console.Write("Введите число M: ");
    int M = int.Parse(Console.ReadLine());
    Console.Write("Введите число N: ");
    int N = int.Parse(Console.ReadLine());

    double[,] array = fill_array_TWO_dimensional(M, N, -10, 10, 0);

    print_array_TWO_dimensional(array);

    Break();
}

void Exemple50() // Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив: 
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
{
    Console.Clear();
    Console.WriteLine("Задача 50. Показывает значение выбранной позиции в двумерном массиве.\n");

    double[,] array = fill_array_TWO_dimensional(3, 4);
    print_array_TWO_dimensional(array);

    Console.Write("Для поиска значения\nВведите номер строки: ");
    int row = int.Parse(Console.ReadLine());

    if (row > 0 & row <= array.GetLength(0)) {
        Console.Write("Введите номер столбца: ");
        int col = int.Parse(Console.ReadLine());

        if (col > 0 & col <= array.GetLength(1)) Console.WriteLine($"\nЧисло в выбранной позиции = {array[row - 1, col - 1]}");
        else Console.WriteLine("\nТакой позиции в массиве нету");
    }
    else Console.WriteLine("\nТакой позиции в массиве нету");

    Break();
}

void Exemple52() // Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
{
    double[] average_collumn(double[,] input_array) {
        double[] average_collumn = new double[input_array.GetLength(1)];

        for (int j = 0; j < input_array.GetLength(1); j++) {
            for (int i = 0; i < input_array.GetLength(0); i++) {
                average_collumn[j] = average_collumn[j] + input_array[i, j];
            }
            average_collumn[j] = Math.Round(average_collumn[j] / input_array.GetLength(0), 1);
        }

        return average_collumn;
    }

    Console.Clear();
    Console.WriteLine("Задача 52. Находит среднее арифметическое в каждом столбце.\n");

    double[,] array = fill_array_TWO_dimensional(3, 4, 1);
    print_array_TWO_dimensional(array);

    double[] average_col = average_collumn(array);
    
    for (int i = 0; i < array.GetLength(1); i++) {
        Console.WriteLine($"Среднее арифметическое {i + 1} столбца = {average_col[i]}");
    }

    Break();
}

void Exemple_9() // Дополнительная задача (задача со звёздочкой): Задайте двумерный массив из целых чисел. 
// Определите, есть столбец в массиве, сумма которого, больше суммы элементов расположенных 
// в четырех "углах" двумерного массива.
// Например, задан массив:
// 4 4 7 5
// 4 3 5 3
// 8 1 6 8 -> нет
// 2 4 7 2
// 4 3 5 3
// 2 1 6 2 -> да
{
    void check_sum(double[,] input_array) {
        double sum_angles = input_array[input_array.GetLength(0) - 1, input_array.GetLength(1) - 1] 
                            + input_array[0, input_array.GetLength(1) - 1]
                            + input_array[0, 0]
                            + input_array[input_array.GetLength(0) - 1, 0];
    
        double sum_col = 0;
        int count = 0;

        for (int j = 0; j < input_array.GetLength(1); j++) {
            for (int i = 0; i < input_array.GetLength(0); i++) {
                sum_col = sum_col + input_array[i, j];
            }
            if (sum_col > sum_angles) {
                Console.WriteLine($"Сумма столбца {j + 1} больше суммы углов в этом массиве.");
                count = 1;
            }
            sum_col = 0;
        }

        if (count == 0) Console.WriteLine("В данном массиве нет таких столбцов.");
    }

    Console.Clear();
    Console.WriteLine("Задача *. Определяет есть ли столбец, сумма элементов которого больше "
        + "суммы элементов в углах двумерного массива.\n");

    double[,] array = fill_array_TWO_dimensional(3, 4, 1);
    print_array_TWO_dimensional(array);

    check_sum(array);

    Break();
}

void Exemple_10() // Дополнительная задача 2 (задача со звёздочкой): Вывести первые n строк треугольника Паскаля. 
// Реализовать вывод в виде равнобедренного треугольника.
// N = 7 -> https://ibb.co/yWPZbG7
{
    double[,] Paskal_treangle(double[,] input_array) {
        int middle = input_array.GetLength(0) - 1;
        input_array[0, middle] = 1;

        if (input_array.GetLength(0) >= 1) {
            input_array[1, middle - 1] = 1;
            input_array[1, middle + 1] = 1;

            for (int i = 2; i < input_array.GetLength(0); i++) {
                input_array[i, middle - i] = 1;
                input_array[i, middle + i] = 1;

                if (i % 2 == 0) {
                    input_array[i, middle] = input_array[i - 1, middle - 1] + input_array[i - 1, middle + 1];
                    for (int j = 2; j < i; j += 2) {
                        input_array[i, middle - j] = input_array[i - 1, middle - j + 1] + input_array[i - 1, middle - j - 1];
                        input_array[i, middle + j] = input_array[i, middle - j];
                    }
                }
                else {
                    input_array[i, middle - 1] = input_array[i - 1, middle - 2] + input_array[i - 1, middle];
                    input_array[i, middle + 1] = input_array[i, middle - 1];
                    for (int j = 2; j < i - 1; j += 2) {
                        input_array[i, middle - j - 1] = input_array[i - 1, middle - j - 2] + input_array[i - 1, middle - j];
                        input_array[i, middle + j + 1] = input_array[i, middle - j - 1];
                    }
                }
            }
        }



        return input_array;
    }

    string replace(double[,] input_array) {
        string result = String.Empty;
        string value = String.Empty;

        for (int i = 0; i < input_array.GetLength(0); i++) {
            for (int j = 0; j < input_array.GetLength(1); j++) {
                value = Convert.ToString(input_array[i, j]);
                if (value == "0") value = " ";
                result = result + value;
            }
            result = result + "\n";
        }

        return result;
    }

    Console.Clear();
    Console.WriteLine("Задача **. Выводит N строк треугольника Паскаля.\n");
    Console.Write("Введите число N: ");
    int N = int.Parse(Console.ReadLine());
    int K = N * 2 - 1;

    double[,] array = fill_array_TWO_dimensional(N, K, 0, 1);

    Paskal_treangle(array);
    
    Console.WriteLine(replace(array));

    Break();
}

void Exemple54() // Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
{
    double[,] sort_of_descending(double[,] input_array) {
        double max = 0;
        double max_second = 0;

        for (int i = 0; i < input_array.GetLength(0); i++) {
            for (int k = 0; k < input_array.GetLength(1); k++) {
                max = input_array[i, k];
                for (int j = 0; j < input_array.GetLength(1); j++) {
                    if (input_array[i, j] < max) {
                        max_second = max;
                        max = input_array[i, j];
                        input_array[i, j] = max_second;
                        input_array[i, k] = max;
                    }
                }
            }
        }

        return input_array;
    }

    Console.Clear();
    Console.WriteLine("Задача 54. Упорядочивает каждую строчку двумерного массива (M x N) в порядке убывания.\n");
    Console.Write("Введите число M: ");
        int M = int.Parse(Console.ReadLine()); 
    Console.Write("Введите число N: ");
        int N = int.Parse(Console.ReadLine());
    Console.WriteLine();

    double[,] array = fill_array_TWO_dimensional(M, N, 1);
    print_array_TWO_dimensional(array);

    sort_of_descending(array);

    print_array_TWO_dimensional(array);

    Break();
}

void Exemple56() // Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
{
    void min_sum_row(double[,] input_array) {
        double sum(double[,] input_array, int index) {
            double sum = 0;
            for (int j = 0; j < input_array.GetLength(1); j++) {
                sum += input_array[index, j];
            }
            return sum;
        }
        
        int index = 0;
        double sum_row = sum(input_array, index);

        for (int i = 0; i < input_array.GetLength(0); i++) {
            if (sum(input_array, i) < sum_row) {
                sum_row = sum(input_array, i);
                index = i;
            }
        }

        Console.WriteLine($"Строка с наименьшей суммой элементов - {index + 1}.");
    }

    Console.Clear();
    Console.WriteLine("Задача 56. Находит строку с наименьшей суммой элементов в массиве (M x N).\n");
    Console.Write("Введите число M: ");
        int M = int.Parse(Console.ReadLine()); 
    Console.Write("Введите число N: ");
        int N = int.Parse(Console.ReadLine());
    Console.WriteLine();

    double[,] array = fill_array_TWO_dimensional(M, N, 1);
    print_array_TWO_dimensional(array);

    min_sum_row(array);
    
    Break();
}

void Exemple58() // Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
{
    double[,] multiplay_array(double[,] input_array_one, double[,] input_array_two) {
        double multiplay = 0;
        double[,] multi_array = new double[input_array_one.GetLength(0), input_array_two.GetLength(1)];

        for (int i = 0; i < input_array_one.GetLength(0); i++) {
            for (int k = 0; k < input_array_two.GetLength(1); k++) {
                for (int j = 0; j < input_array_one.GetLength(1); j++) {
                    multiplay = input_array_one[i, j] * input_array_two[j, k] + multiplay;
                }
                multi_array[i, k] = multiplay;
                multiplay = 0;
            }
        }

        return multi_array;
    }

    Console.Clear();
    Console.WriteLine("Задача 58. Находит произведение 2х матриц A (M x N) и B (N x K).\n");
    Console.Write("Введите число M для матрицы A: ");
        int M_one_array = int.Parse(Console.ReadLine()); 
    Console.Write("Введите число N: ");
        int N_array = int.Parse(Console.ReadLine());
    Console.Write("Введите число L для матрицы B: ");
        int L_two_array = int.Parse(Console.ReadLine());
    Console.WriteLine();

    Console.WriteLine("Матрица A.\n");
    double[,] array_one = fill_array_TWO_dimensional(M_one_array, N_array, 1);
    print_array_TWO_dimensional(array_one);

    Console.WriteLine("Матрица B.\n");
    double[,] array_two = fill_array_TWO_dimensional(N_array, L_two_array, 1);
    print_array_TWO_dimensional(array_two);

    Console.WriteLine("Произведение матриц.\n");
    double[,] array = multiplay_array(array_one, array_two);
    print_array_TWO_dimensional(array);
    
    Break();
}

void Exemple_11() // Дополнительная задача (задача со звёздочкой): 
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// // Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
{
    int[,,] fill_array_THREE_dimensional(int rows, int columns, int plane, int min = 10, int max = 100) {
        int[,,] array = new int[rows, columns, plane];

        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < columns; j++) {
                for (int k = 0; k < plane; k++) {
                    array[i, j, k] = new Random().Next(min, max);
                }
            }
        }

        return array;
    }

    void search_equal_number(int[,,] input_array) {
        int new_number = 10;
        int count_equal_number = 0;

        for (int i = 0; i < input_array.GetLength(0); i++) {
            for (int j = 0; j < input_array.GetLength(1); j++) {
                for (int k = 0; k < input_array.GetLength(2); k++) {
                    if (count_number(input_array, input_array[i, j, k]) > 1) {
                        count_equal_number += 1;
                        while (count_number(input_array, new_number) > 0) {
                            new_number += 1;
                        }
                        input_array[i, j, k] = new_number;
                    }
                }
            }
        }
        
        if (count_equal_number > 0) {
            Console.WriteLine("В массиве были повторяющиеся цифры, вот новый массив.\n");
            print_array_THREE_dimensional(input_array);
        }
        else Console.WriteLine("В массиве нет повторяющихся читсел.");
    }

    int count_number(int[,,] input_array, int number) {
        int count = 0;

        for (int i = 0; i < input_array.GetLength(0); i++) {
            for (int j = 0; j < input_array.GetLength(1); j++) {
                for (int k = 0; k < input_array.GetLength(2); k++) {
                    if (number == input_array[i, j, k]) count += 1;
                }
            }
        }
        return count;
    }

    void print_array_THREE_dimensional(int[,,] input_array) {
        for (int i = 0; i < input_array.GetLength(0); i++) {
            for (int j = 0; j < input_array.GetLength(1); j++) {
                for (int k = 0; k < input_array.GetLength(2); k++) {
                    Console.Write($" {input_array[i, j, k]} ({i}, {j}, {k})  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }

    Console.Clear();
    Console.WriteLine("Задача *. Формирует 3х мерный массив (M x N x K) с неповторяющими числами и выводит его на экран с индексами.\n");
    Console.Write("Введите число M: ");
    int M = int.Parse(Console.ReadLine()); 
    Console.Write("Введите число N: ");
    int N = int.Parse(Console.ReadLine());
    Console.Write("Введите число K: ");
    int K = int.Parse(Console.ReadLine());
    Console.WriteLine();

    Console.WriteLine("Изначальный массив\n");
    int[,,] array = fill_array_THREE_dimensional(M, N, K);
    print_array_THREE_dimensional(array);

    search_equal_number(array);

    Break();
}

void Exemple_12() // Дополнительная задача 2 (задача со звёздочкой):. 
// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
{
    int[,] fill_array_spiral(int rows, int columns) 
    {
        int[,] filled_array = new int[rows, columns];
        int row = 0;
        int col = 0;
        int number = 10;
        int n = 0;
        int count_row_i = 0;
        int count_col_j = 0;

        for (int k = 1; k < rows + columns; k++) {
            if (k % 2 == 1) {
                if (count_row_i == 0) {
                    row = n;
                    for (int j = 0 + n; j < columns - n; j++) {
                        filled_array[row, j] = number;
                        number += 1;
                    }
                    n += 1;
                    count_row_i = 1;
                }
                else {
                    row = rows - n;
                    for (int j = columns - 1 - n; j >= n - 1; j--) {
                        filled_array[row, j] = number;
                        number += 1;
                    }
                    count_row_i = 0;
                }
            }
            else {
                if (count_col_j == 0) {
                    col = columns - n;
                    for (int i = n; i < rows - n + 1; i++) {
                        filled_array[i, col] = number;
                        number += 1;
                    }
                    count_col_j = 1;
                }
                else {
                    col = n - 1;
                    for (int i = rows - 1 - n; i > n - 1; i--) {
                        filled_array[i, col] = number;
                        number += 1;
                    }
                    count_col_j = 0;
                }
            }
        }

        return filled_array;
    }

    void print_array_spiral(int[,] input_array) {
        for (int i = 0; i < input_array.GetLength(0); i++) {
            for (int j = 0; j < input_array.GetLength(1); j++) Console.Write(" " + input_array[i, j] + " ");
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    Console.Clear();
    Console.WriteLine("Задача **. Заполнение 2х мерного массива (M * N) спирально.\n");
    Console.Write("Введите число M: ");
    int M = int.Parse(Console.ReadLine()); 
    Console.Write("Введите число N: ");
    int N = int.Parse(Console.ReadLine());
    Console.WriteLine(); 

    int[,] array = fill_array_spiral(M, N);
    print_array_spiral(array);

    Break();
}

int[] fill_array_ONE_dimensional(int size, int min = 1, int max = 10) // Заполнение 1 мерного массива случайными числами 
{
    int[] filled_array = new int[size];
    for (int i = 0; i < size; i++) {
        filled_array[i] = new Random().Next(min, max);
    }
    return filled_array;
}

void print_array_ONE_dimensional(int[] input_array) // Вывод 1 мерного массива
{
    Console.Write($"\n[{String.Join(",", input_array)}]");
    Console.WriteLine();
}

double[,] fill_array_TWO_dimensional(int rows, int columns, int min = -10, int max = 10, double mode = 1) // Заполнение 2 мерного массива случайными числами 
{
    double[,] filled_array = new double[rows, columns];

    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < columns; j++) {
            if (mode == 0) filled_array[i, j] = Math.Round(new Random().NextDouble() * new Random().Next(min, max), 1);
            else filled_array[i, j] = new Random().Next(min, max);
        }
    }
    return filled_array;
}

void print_array_TWO_dimensional(double[,] input_array) // Вывод 2 мерного массива
{
    for (int i = 0; i < input_array.GetLength(0); i++) {
        for (int j = 0; j < input_array.GetLength(1); j++) {
            Console.Write(" " + input_array[i, j]);
        }
        Console.WriteLine();
    }
}

void Break() // Завершение програграммы
{
    Console.WriteLine("\nДля выбора Другой задачи введите 5.     Для выхода из программы 0.\n");
    int ret = int.Parse(Console.ReadLine());

    if (ret == 5) Run();
    else if (ret != 0) Break();
}