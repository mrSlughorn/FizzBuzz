﻿// See https://aka.ms/new-console-template for more information



int number = 0;

for (int i = 0; i < 100; i++)
{
    number++;
    if (number % 3 == 0 && number % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }

    else if(number % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    
    else if(number % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }

    else
    {
        Console.WriteLine(number);
    }
}