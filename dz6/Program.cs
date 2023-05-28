// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Clear();
Console.Write("Введите целое число ");
int numberA =  int.Parse(Console.ReadLine());

if(numberA %2 == 0)
{
Console.WriteLine($"{numberA} Является четным числом ");
}

else
{
    Console.WriteLine($"{numberA} Является нечетным числом ");
}
