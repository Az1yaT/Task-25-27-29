// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Clear();

Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int cube(int numberA, int numberB)
{
    int num = 1;
    for (int i = 1; i <= numberB; i++)
    {
        num = num * numberA;
    }
    return num;
}

int result = cube(numberA, numberB);
Console.WriteLine($"Ответ: {result}");