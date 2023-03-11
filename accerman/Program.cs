// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Ackerman(int n, int m)
{
    if (n==0) return (m+1);
    else if ((n!=0)&&(m==0)) return (Ackerman(n-1, 1));
    else return(Ackerman(n-1, Ackerman(n, m-1)));
}
Console.WriteLine("Введите значение n");
int n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение m");
int m=Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Достоверно не понятно и не известно что вычисляет эта функция, но при значениях n, m равных {n} {m} значение равно:");
Console.WriteLine(Ackerman(n,m));