namespace Week8;

public class Program
{
    static void Main()
    {

        Point p1 = new Point { X = 1, Y = 2 };
        Point p2 = p1;

        p2.Y = 5;
        Console.WriteLine($"p1 & p2 :");
        p1.Print();
        p2.Print();

        PointRef r1 = new PointRef { X = 1, Y = 2 };
        PointRef r2 = r1;

        r2.X = 6;
        Console.WriteLine("r1 & r2 :");
        r1.Print();
        r2.Print();
        
        Console.WriteLine();
        BoxingTester.Test();
    }
}