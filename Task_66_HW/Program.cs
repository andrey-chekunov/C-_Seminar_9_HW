// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int m = InputNumbers("Input M: ");
int n = InputNumbers("Input N: ");
int sum = 0;
int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
Sum(m, n, sum);
void Sum(int m, int n, int sum)
{
    if (m > n)
    {
        Console.WriteLine($"The sum of natural elements in the range from M to N: {sum}");
        return ;
    }
    sum = sum + (m++);
    Sum(m , n, sum);
}