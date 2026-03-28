namespace Week8;

public struct PointRef
{
    public int X { get; set; }
    public int Y { get; set; }

    public void Print()
    {
        Console.WriteLine($"Points: x={X}, y={Y}");
    }
}