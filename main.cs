using System;

class Program
{
    private const double CM_PER_INCH = 2.54;

    static void Main()
    {
        double inches = 10;
        Console.WriteLine($"{inches} inches is {inches * CM_PER_INCH} centimeters.");
    }
}
