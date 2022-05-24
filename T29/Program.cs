// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] FillRandomArray(int length, int deviation)
{
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(-deviation, deviation);
    }
    return result;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i != array.Length)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

Console.Write("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите диапазон массива: ");
int deviation = Convert.ToInt32(Console.ReadLine());
Console.Write("Массив в диапазоне отрицательного и положительного введенного Вами значения");
int[] array = FillRandomArray(length, deviation);
PrintArray(array);
