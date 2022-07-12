// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

void Zadacha10() 

    {
        //Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
        
        Random rand = new Random();
        int number = rand.Next(100, 1000);
        Console.WriteLine(number);

        int ones = number % 10;
        int tens = number / 10;
        int hundred = number / 100;
        //Console.WriteLine(ones);
        Console.WriteLine(tens - hundred * 10);
        //Console.WriteLine(hundred);


    }
//Zadacha10();

void Zadacha13() 

    {
        //Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
        
        Console.WriteLine("Введите число от 10 до 999");
        int number = Convert.ToInt32(Console.ReadLine());
        int ones = number % 10;
        int tens = number / 10;
        int hundred = number / 100;
        //Console.WriteLine(ones);
        //Console.WriteLine(tens - hundred * 10);
        if (hundred == 0 )
        {
            Console.WriteLine("Третьей цифры нет");
        }
        else Console.WriteLine(ones);


    }
//Zadacha13();

void Zadacha15() 

    {
        //Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
        
        Console.WriteLine("Введите цифру от 1 до 7");
        int number = Convert.ToInt32(Console.ReadLine());
        int ones = number % 10;
        int tens = number / 10;
        int hundred = number / 100;
        //Console.WriteLine(ones);
        //Console.WriteLine(tens - hundred * 10);
        if (number > 5 && number < 8 )
        {
            Console.WriteLine("Ура, выходной!");
        }
        else Console.WriteLine("Рабочий");


    }
Zadacha15();
