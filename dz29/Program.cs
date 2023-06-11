// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();
int Prompt(string message)
{
    Console.Write(message); //Выводим приглашение к вводу
    string ReadInput = Console.ReadLine(); // сама строка куда вводим
    int result = int.Parse(ReadInput); // приводим введеную строку к числу
    return result; // Возвращаем рузультат
}
// Метод для получения случайных значений массива
int[] GenerateArray(int Length, int minValue, int maxValue)
{
    int[] array = new int[Length]; // объявляем массив
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + i); // Заполняем случайными цифрами
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - i; i++)
    {
        Console.Write($"{array[i]}, "); // Вывод значения массива
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.WriteLine("]");
}
int Length = Prompt("Длина массива: ");
int min = Prompt("Начальное значение, для диапазона случайного числа: ");
int max = Prompt("Конечное значение, для диапазона случайного числа: ");
int[] array = GenerateArray(Length, min, max); // Заполнение массива случайнми числами
PrintArray(array); //Вывод массива