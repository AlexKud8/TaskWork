// See https://aka.ms/new-console-template for more information
//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22


 Console.WriteLine("Введите число 1е: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите число 2е: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите число 3е: ");
        int num3 = Convert.ToInt32(Console.ReadLine());

        if (num1 > num2) 
        {
            Console.Write(num1);
        }
        else if (num2 > num3)
        {
            Console.Write(num2);
        }
        else if (num3 > num1)
        {
            Console.Write(num3);
        }
        else
        {
            Console.Write(num1);
        }


