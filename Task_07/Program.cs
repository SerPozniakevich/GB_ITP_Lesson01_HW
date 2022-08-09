// Задача 7. Напишите программу, которая на вход принимает трёхзначное число 
// и на выходе показывает последнюю цифру этого числа.

Console.Clear();
Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (99 > num || num > 1000)
{
    Console.Write("Вы ввели не трёхзначное число");
}
else
{
    Console.Write("Последняя цифра числа: ");
    Console.WriteLine(num % 10); 
}
