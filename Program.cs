//Task 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Input the first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second number ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2)
{
    Console.WriteLine("It is not possible to determine the max and min number. The entered numbers are equal to each other and equal " + number1);
}
else
{
    if (number1 > number2)
    {
        Console.WriteLine($"The max number is {number1}, the min number is {number2}");
    }
    else
    {
        Console.WriteLine($"The max number is {number2}, the min number is {number1}");
    }
}