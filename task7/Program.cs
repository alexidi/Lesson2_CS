// Напишите программу, которая выводит третью с
// конца цифру заданного числа или сообщает, что
// третьей цифры нет.
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num < 100)
{
    Console.WriteLine("Третей цифры нет!");
}
else
{
    while (num > 999)
    {
        num /= 100;
    }
    Console.WriteLine(num % 10);
}