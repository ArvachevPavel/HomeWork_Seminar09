// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N
Console.WriteLine("Введите целое положительное число");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите ещё одно целое положительное число, больше первого");
int n = int.Parse(Console.ReadLine());
while (m < 0 || n < 0)
{
    if (m < 0)
    {
        Console.Write("Вы ввели отрицательное первое число. Введите число заново : ");
        m = int.Parse(Console.ReadLine());
    }
    if (n < 0)
    {
        Console.Write("Вы ввели отрицательное второе число. Введите число заново : ");
        n = int.Parse(Console.ReadLine());
    }
}
while (m >= n)
{
    Console.Write("Вы ввели второе число меньше чем первое. ");
    Console.Write("Введите второе число, больше первого: ");
    n = int.Parse(Console.ReadLine());    
}
Console.WriteLine();
Console.Write("Диапазон между первым и вторым числом: ");
int max = m;
int sum = 0;
for (int i = m; i < n; i++)
{
    Console.Write(max + ", ");
    max = max + 1;
    sum += i;
    
}
Console.Write(n);
Console.WriteLine();
Console.WriteLine("Сумма всех чисел в промежутке от первого до второго: " + (sum + n));

