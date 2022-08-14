// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 10000 || num > 99999) Console.WriteLine("Введено некорректное число");
else
{
    int[] array5sym = new int[5];
    int index = 4;
    while (index >= 0)
    {
        array5sym[index] = num % 10;
        num = num / 10;
        index--;
    }
    if (array5sym[0]==array5sym[4] && array5sym[1]==array5sym[3]) Console.WriteLine($"Введенное число - палиндром. Поздравляю!");
    else Console.WriteLine($"Введенное число не является палиндромом. Приходите ещё!");
}