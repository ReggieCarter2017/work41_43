/* Console.WriteLine("Сколько чисел вы хотите ввести? ");
int.TryParse(Console.ReadLine(), out int count);
*/
int CountingPositiveIntegers(int a)
{
    int howManyTimes = 0;
    bool stop = true;
    while (stop)
    {
        Console.WriteLine("Введите ваше число: ");
        int.TryParse(Console.ReadLine(), out var numFromUser);
        if (numFromUser != a && numFromUser > 0) howManyTimes++;
        else if (numFromUser == a) stop = false;
    }
    return howManyTimes;
}
int stop1 = 999;
Console.WriteLine("Введите в терминал '" + stop1 + "' для прекращения ввода чисел");
Console.Write($" Положительных чисел: {CountingPositiveIntegers(stop1)}.");
