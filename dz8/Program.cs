// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Clear();
Console.Write("Введите целое число ");
int numberA = Math.Abs(int.Parse(Console.ReadLine()));  
Console.WriteLine($"Четные числа от 1 до  {numberA}:");
int i = 2; // Первое четное число

while(i <= numberA)
{
    Console.WriteLine(i);
    i+=2;
}

