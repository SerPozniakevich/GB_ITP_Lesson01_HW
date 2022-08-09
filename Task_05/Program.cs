// Задача 8. Напишите программу, котораяпринимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int i = 0;

while (i < num-1)
{
    i += 2;
    Console.Write( i + ", ");
}