using System;
using System.ComponentModel.DataAnnotations;

class Circle
{

    private float square;
    private float length;


    public float Rad { get; set; }



    public float Len
    {
        get { return length; }
        set { length = (float)(2 * Math.PI * Rad); }
    }


    public float Square
    {
        get { return square; }
        set { square = (float)Math.PI * (Rad * Rad); }
    }


    public bool Check()
    {
        if (Rad >= 0 && Rad <= 12)
        {
            return true;
        }
        else
        {
            return false;
        }
    }



    public override string ToString()
        => "Radius:" + Rad + "\nLength:" + length + "\nSquare:" + square;

}

class Program
{
    static void Main(string[] args)
    {
        Console.BackgroundColor = ConsoleColor.DarkGray;

        Circle circle = new Circle();
        circle.Rad = 11.99f;

        if (circle.Check())
        {
            circle.Len = circle.Rad;
            circle.Square = circle.Rad;

            Console.WriteLine(circle);
        }
        else
        {
            Console.WriteLine("Incorrect radius value!");
        }

        Console.ResetColor();
        Console.ReadKey();
    }
}
