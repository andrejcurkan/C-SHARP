/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine($"{number1} больше чем {number2}");
}
else if (number1 < number2)
{
    Console.WriteLine($"{number1} меньше чем {number2}");
}
else
{
    Console.WriteLine("Числа равны");
}
*/


/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int number3 = Convert.ToInt32(Console.ReadLine());
int maxNumber = number1;
if (number2 > maxNumber)
{
     maxNumber = number2;
}

if (number3 > maxNumber)
{
      maxNumber = number3;
}
Console.WriteLine($"Максимальное число: {maxNumber}");
*/    

/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
      Console.WriteLine($"{number} это четное число.");
}
else
{
      Console.WriteLine($"{number} это нечетное число.");
}
*/

/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Четные числа от 1 до {N}:");
for (int i = 2; i <= N; i += 2)
{
      Console.WriteLine(i);
}
/*        

        
