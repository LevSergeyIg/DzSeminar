// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Clear();
Console.Write("Введите первое число ");
 int numberA =  int.Parse(Console.ReadLine());
Console.Write("Введите второе число ");
 int numberB =  int.Parse(Console.ReadLine());
 Console.Write("Введите третье число ");
 int numberC = int.Parse(Console.ReadLine());

int max = numberA;

 if (numberA > max) max = numberA;
 if (numberB > max) max = numberB;
 if (numberC > max) max = numberC;

 Console.Write("Максимальное число = ");
 Console.WriteLine(max);

