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

int max = 0;

if(number1 > number2)
{
   max = number1;
}
else
{
    max = number2;
}

if(number3 > max)
{
    Console.Write("Max number is " + number3);
}
else
{
    Console.Write("Max number is " + max);
}


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


//Task 4 Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Input a positive integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = 1;

if(num != 1)
{
    while(current <= num)
    { 
        if(current%2 == 0)
    {
        Console.Write(current + " ");
    }
    current++;
    } 
}
else
{
    Console.Write("No positive integer numbers between 1 and the input number");
}

*/

