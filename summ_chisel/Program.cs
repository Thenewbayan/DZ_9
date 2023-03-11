//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
/// <summary>
/// Сумма натуральных чисел в диапазоне
/// </summary>
/// <param name="min">мин значение</param>
/// <param name="max">макс занчение</param>
/// <returns></returns>
int GetSummInt(int min, int max)
{
   if(min==max) return min;
   return (min+GetSummInt(min+1, max));
}
Console.WriteLine("Найдем значения элементов в диапазоне");
Console.WriteLine("Введите мин и макс значения натуральных чисел");
int min=Convert.ToInt32(Console.ReadLine());
int max=Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма элементов  в диапазоне {min}-{max}:");
Console.WriteLine(GetSummInt(min,max));