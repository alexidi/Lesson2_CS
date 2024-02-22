// Напишите программу, которая принимает на
// вход трёхзначное число и удаляет вторую
// цифру этого числа.
// 576
// Console.Write("Введите трехзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
int num = new Random().Next(50, 2000);
Console.WriteLine(num);
if (num <= 999 && num >= 100)
{
    int num1 = num / 100;
    int num2 = num % 10;
    Console.WriteLine($"{num1}{num2}");
}
else
{
    Console.WriteLine("Введено не трехзначное число");
}