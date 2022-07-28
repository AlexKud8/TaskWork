
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] arrayNewNumbers = new double[10];
  for (int i = 0; i < arrayNewNumbers.Length; i++ )
  {
    arrayNewNumbers[i] = new Random().Next(1, 10);
    Console.Write(arrayNewNumbers[i] + " ");
  }

double maxNumber = arrayNewNumbers[0];
double minNumber = arrayNewNumbers[0];

  for (int i = 1; i < arrayNewNumbers.Length; i++)
  {
    if (maxNumber < arrayNewNumbers[i])
    {
      maxNumber = arrayNewNumbers[i];
    }
        if (minNumber > arrayNewNumbers[i])
    {
      minNumber = arrayNewNumbers[i];
    }
  }

  double decision = maxNumber - minNumber;

  Console.WriteLine($"\nразница между между максимальным ({maxNumber}) и минимальным({minNumber}) элементами: {decision}");