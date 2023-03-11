//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
//в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.WriteLine("Покажем все натуральные числа в диапазоне");
/// <summary>
/// Показывает все натуральные числа в диапазоне
/// </summary>
/// <param name="min">мин значение</param>
/// <param name="max">макс значение</param>
/// <returns></returns>
string GetIntNumbers(int min, int max)
{
    
    if(max==min) return min.ToString();
    return (min+ ", " + GetIntNumbers(min+1, max));
}
Console.WriteLine("Введите мин и макс значения натуральных чисел");
int min=Convert.ToInt32(Console.ReadLine());
int max=Convert.ToInt32(Console.ReadLine());
if (min<0||max<0)
{
    Console.WriteLine("Натуральные числа - целые положительные числа, вы ввели не те");
    return;
}

Console.WriteLine($"НАтуральные числа в диапазоне {min}-{max}:");
Console.WriteLine(GetIntNumbers(min, max));

