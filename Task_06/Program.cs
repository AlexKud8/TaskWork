﻿//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет

Console.WriteLine("Введите число : ");
int e ;
 e = Console.Read();
       
        if ((e % 2)== 0)
        {
          Console.WriteLine("Да");  
        } 
        else 
        {
          Console.WriteLine("Нет");  
        } 
