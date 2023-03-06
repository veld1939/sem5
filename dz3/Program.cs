// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] number = new double[10];
Random rand = new Random();

 for (int i = 0; i < number.Length; i++)
{
    number[i] = rand.NextDouble() + 10;
}

double max = number[0];
double result = 0;
double min = number[0];

for (int i = 0; i < number.Length; i++)
{
    number[i] = rand.NextDouble() + 10;

     if(number[i] > max) 
     {
        max = number[i];
     } 
     if (number[i] < min)
     {
     min = number[i];
     } 
    result = max - min; 
}
System.Console.WriteLine(string.Join("  ", number.Select(n => $"{n:F3}")));
Console.WriteLine($"Максимальный элемент{max}");
Console.WriteLine($"Минимальный элемент{min}");
Console.Write($"Разница = {result}");
