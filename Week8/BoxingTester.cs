namespace Week8;

public static class BoxingTester
{
    public static void Test()
    {
        int a = 10;
        object b = a;
        int c = (int)b;
        
        Console.WriteLine($"main : {a}");
        Console.WriteLine($"Boxed : {b}");
        Console.WriteLine($"Unboxed : {c}");
        
        // value does not change in a even though you change b, because it was boxed
    }
}