﻿//11. Напишите программу, которая выводит случайное
//трёхзначное число и удаляет вторую цифру этого
//числа.
//456 -> 46
//782 -> 72
//918 -> 98

int rndNum = new Random().Next(100,1000);

Console.WriteLine(rndNum);

int newNum = rndNum / 100 * 10 + rndNum % 10;

Console.WriteLine(newNum);