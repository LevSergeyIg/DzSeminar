// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();
int number = System.Convert.ToInt32(Console.ReadLine());

if(number ==6 || number ==7)
{
    System.Console.WriteLine("Ура, можно в бар");
}
else if(number > 0 && number < 6)
{
    System.Console.WriteLine("Опять пахать");
}