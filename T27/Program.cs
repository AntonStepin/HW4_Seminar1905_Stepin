// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumOfDigits(int number)
{
    int sum = 0;
    if (number > 0)
    {
        while (number > 0)
        {
            sum = sum + (number % 10);
            number = number / 10;
        }
    }
    else if (number < 0)
    {
        while (number < -10)
        {
            sum = sum + (number % 10) * -1;
            number = number / 10;
        }
        sum = sum + (number % 10);
    }
    return sum;
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Сумма чисел равна: ");
Console.Write(SumOfDigits(number));
