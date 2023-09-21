using System.ComponentModel.Design;

var number = 1;

while (number != 150)
{
    if (number % 105 == 0)
    {
        Console.WriteLine("Fizzbuzzbazz");
    }
    else if (number % 3 == 0 && number % 5 == 0)
    {
        Console.WriteLine("Fizzbuzz");
    }
    else if (number % 3 == 0 && number % 7 == 0)
    {
        Console.WriteLine("Fizzbazz");
    }
    else if (number % 5 == 0 && number % 7 == 0)
    {
        Console.WriteLine("Buzzbazz");
    }
    else if (number % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (number % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else if (number % 7 == 0)
    {
        Console.WriteLine("Bazz");
    }
    else { Console.WriteLine(number); }
    number = number + 1;
}

