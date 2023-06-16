namespace StructureData;

internal class Program
{
    public static void Main(string[] args)
    {
        var test = new LinkedListGeneric<int>();
        test.AddFirst(5);
        var count = test.Count();
        Console.WriteLine(count);
    }
}
