namespace StructureData;

internal class Program
{
    public static void Main(string[] args)
    {
        //For UnitTest
        var list = new ListDynamicArray<int>();
        TestIntList(list);
        
    }

    private static void TestIntList(ListDynamicArray<int> list)
    {
        Console.WriteLine("Test Add");
        
        list.Add(4);
        list.Add(8);
        list.Print();
        Console.WriteLine();
        //Output 4 8
        Console.WriteLine("Test clear");
        list.Clear();
        Console.WriteLine(list.Count);
        Console.WriteLine(list.Capacity);
        Console.WriteLine();
        //Output 0
        //Output 5
        Console.WriteLine("Fill list");
        list.Add(5);
        list.Add(2);
        list.Add(6);
        list.Add(1);
        list.Add(12);
        list.Add(113);
        list.Print();
        Console.WriteLine();
        //Output 5 2 6 1 12 113
        Console.WriteLine(list.Count);
        Console.WriteLine(list.Capacity);
        Console.WriteLine();
        //Output 6 10
        Console.WriteLine("Test IndexOf");
        Console.WriteLine(list.IndexOf(6));
        Console.WriteLine();
        //Output 2
        Console.WriteLine("Test Insert");
        list.Insert(2,1000);
        list.Print();
        Console.WriteLine();
        //Output 5 2 1000 6 1 12 113
        Console.WriteLine("Test Insert in index > count");
        list.Insert(1000,100000);
        list.Print();
        Console.WriteLine();
        //Output 5 2 1000 6 1 12 113 100000
        Console.WriteLine("Test Remove");
        list.Remove(1000);
        list.Print();
        Console.WriteLine();
        //Output 5 2 6 1 12 113 100000
        Console.WriteLine("test RemoveAt");
        list.RemoveAt(3);
        list.Print();
        Console.WriteLine();
        //Output 5 2 6 12 113 100000
        Console.WriteLine("Test Sort");
        list.Sort();
        list.Print();
        Console.WriteLine();
        //Output 2 5 6 12 113 100000
        Console.WriteLine("Reverse");
        list.Reverse();
        list.Print();
        Console.WriteLine();
        //Output 100000 113 12 6 5 2
    }
}
