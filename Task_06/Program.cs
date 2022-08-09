// Задача 5. Напишите программу, котораяпринимает число (N), а на выходе показывает все целые числа от -N до N.

Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int i = -num-1;

while (i < num)
{
    i += 1;
    Console.Write( i + ", ");
}
