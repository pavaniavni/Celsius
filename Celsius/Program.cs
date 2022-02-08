using System;
public class Celsius
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the value of Celsius : ");
        int cel = Convert.ToInt32(Console.ReadLine());
        int Kel = cel + 273;
        int Fah = cel * 18 / 10 + 32;
        Console.WriteLine("The value of Kelvin = {0}", Kel);
        Console.WriteLine("The value of Fahrenheit = {0}", Fah);
    }
}
