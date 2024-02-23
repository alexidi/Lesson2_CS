// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число некратно
// второму, то программа выводит остаток от деления.

Console.Write("Введите первое число: ");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int a2 = Convert.ToInt32(Console.ReadLine());
if(a2 > a1)
{
    int temp = a1;
    a2 = a1;
    a1 = temp;
}

if(a2 == 0)
{
Console.Write("Число не делиться на ноль!!!");
}

{
if(a1 % a2 == 0)
{
    Console.Write("Да");
}
else
{
    Console.Write($"Нет, {a1 % a2}");
}
}

