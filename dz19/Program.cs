// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
System.Console.WriteLine("Введите пятизначное число");
int number = int.Parse(Console.ReadLine());


int i = number / 10000;
int b = number % 10;


if (i == b)
{
    Console.WriteLine("Является палиндромом");
}

else
{
    Console.WriteLine("Не является палиндромом");
}