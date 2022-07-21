// Написать программу, которая на вход
// принимает число и выдает его квадрат
// умнодение само на себя
// 4 -> 16
//-3 -> 9
// -7 -> 49

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int square = num * num;
Console.Write($"Квадрат числа {num} = {square}:");

