// See https://aka.ms/new-console-template for more information



int number = 0;

for (int i = 0; i < 100; i++)
{
    number++;
        // check if the number is divisible by 3 and 5
    if (number % 3 == 0 && number % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }

        // check if number is divisible by 3
    else if(number % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    
        //check if number is divisible by 5
    else if(number % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }

    else
    {
        Console.WriteLine(number);
    }
}