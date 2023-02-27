//Task 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
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


// Task 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Input the first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the third number: ");
int number3 = Convert.ToInt32(Console.ReadLine());


if(number1 > number2)
{
    if(number1 > number3)
    {
        Console.WriteLine("Max number is " + number1);
    }
    else
    {
       Console.WriteLine("Max number is " + number3); 
    }
}
else
{
    if(number2 > number3)
    {
        Console.WriteLine("Max number is " + number2);
    }
    else
    {
     Console.WriteLine("Max number is " + number3);   
    }
}
*/

// Task 3  Напишите программу, которая на вход принимает число 
//и выдаёт, является ли число чётным (делится ли оно на два без остатка)

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num%2 == 0)
{
    Console.Write("The input number is chetnoye");
}
else
{
    Console.Write("The input number is nechetnoye");
}
