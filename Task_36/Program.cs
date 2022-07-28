// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Массив: ");
PrintArray(numbers);
int sum = 0;

for (int i = 0; i < numbers.Length; i++)
    if (i % 2 ==0)
    sum = sum + numbers[i];

    Console.WriteLine($"Чисел {numbers.Length}. Cумма элементов на нечётных позициях = {sum}");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int r = 0; r < numbers.Length; r++)
        {
            numbers[r] = new Random().Next(1,10);
        }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int r = 0; r < numbers.Length; r++)
        {
            Console.Write(numbers[r] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}