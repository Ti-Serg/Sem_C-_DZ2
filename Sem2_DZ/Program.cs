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
        int numberAbs = Math.Abs(number);
        int n = numberAbs;
        int del = 10;
        
        while (numberAbs > del && n > 999)
        {
               n = numberAbs / del;
               del = del * 10;         
        } 
        //Console.WriteLine(n); 
        int ones = n % 10;
        //int tens = n / 10;
        int hundred = n / 100;   
        //Console.WriteLine(ones);
        //Console.WriteLine(tens - hundred * 10);
        //Console.WriteLine(hundred);
        if (hundred == 0 )
        {
            Console.WriteLine("Третьей цифры нет");
        }
        else Console.WriteLine("Третья цифра " + ones);//


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
//Zadacha15();


void Zadacha1() 

    {
        //Задача 1. Написать программу, которая определяет, является ли треугольник со сторонами a, b, c равнобедренным.

        
        Console.WriteLine("Введите длину стороны a");
        int sideA = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите длину стороны b");
        int sideB = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите длину стороны c");
        int sideC = Convert.ToInt32(Console.ReadLine());
        
        if (sideA == sideB || sideA == sideC || sideB == sideC)
        {
            if (((sideA + sideB) > sideC) || ((sideA + sideC) > sideB) || ((sideC + sideB) > sideA))
            {
                Console.WriteLine("Треугольник равнобедренный");
            }
            else if ((sideA == sideB) && (sideA == sideC))
            {
                Console.WriteLine("Треугольник равносторонний");
            }
            else Console.WriteLine("Что ты такое?!");       

        }
        else Console.WriteLine("Треугольник не является равенобедренным");
        
        

    }
//Zadacha1();