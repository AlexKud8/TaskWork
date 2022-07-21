//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3


        Console.WriteLine("Введите число 1е: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите число 2е: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 > num2) 
        {
            Console.Write(num1);
        }
        else
        {
            Console.Write(num2);
        }
