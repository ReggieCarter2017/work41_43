Console.WriteLine("Сколько чисел вы хотите ввести? ");
int.TryParse(Console.ReadLine(), out int count);
int CountingPositiveIntegers(int c)
{
    Console.WriteLine("Введите ваши числа: ");
    int howManyTimes = 0;
    int i = 0;
    while (i < c)
    {
        int.TryParse(Console.ReadLine(), out var numFromUser);
        if (numFromUser > 0)
        {
            howManyTimes++;
        }
        i++;
    }
    return howManyTimes;
}
Console.WriteLine($"Всего положительных чисел: {CountingPositiveIntegers(count)}");