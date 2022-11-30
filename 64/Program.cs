// Задайте значение N. Напишите программу, которая выведет все чётные числа в промежутке от N до 1.
// N = 5 -> "4, 2"
// N = 8 -> "8, 6, 4, 2"
Console.Clear();

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());
int start = 1;
Console.Write($"{EvenNumbers(n, start)} ");

int EvenNumbers(int n, int start)
{
    if (n == start) return n;
    if (start % 2 == 1)
    {
        return EvenNumbers(n, start + 1);
    } 
        Console.Write($"{EvenNumbers(n, start + 1)} ");
        return start;
}


