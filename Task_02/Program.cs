// 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Clear();
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
  
if(num1 < num2) 
{
    Console.Write("Max = ");
    Console.WriteLine(num2);
    Console.Write("Min = ");
    Console.WriteLine(num1);
}
else
{
    Console.Write("Max = ");
    Console.WriteLine(num1);
    Console.Write("Min = ");
    Console.WriteLine(num2);   
}
if(num1 == num2)
{
   Console.Write("Equal"); 
}   
    