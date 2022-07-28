//9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
//78 -> 8 12-> 2 85 -> 8

int rndNum = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 =>{rndNum}");

//int firstDigit = rndNum / 10;
//int secondDigit = rndNum % 10;

//int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;

//if (secondDigit > maxDigit) maxDigit = secondDigit;
//else maxDigit = 0;


//if (maxtDigit > 0) Console.WriteLine($"Наибольшая цифра числа {rndNum} => {maxDigit}");
//else Console.WriteLine($"цифры числа {rndNum} равны");


int MaxDigit(int num)
{
    int firstDigit = rndNum / 10;
    int secondDigit = rndNum % 10;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}
int maxDigit = MaxDigit(rndNum);
string result = maxDigit > 0 ? maxDigit.ToString() : "числа равны";
Console.WriteLine($"Наибольшая цифра числа {rndNum} => {maxDigit}");
