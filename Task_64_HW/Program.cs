// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int number = int.Parse(Console.ReadLine());
int count = 1;
NaturalNumber(number, count);


void NaturalNumber(int number, int count)
{
    if (count > number) return;
    NaturalNumber(number, count + 1);
    Console.Write(count + ", ");
}
Console.Write(count - 1);