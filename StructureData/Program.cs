namespace StructureData;

internal class Program
{
    public static void Main(string[] args)
    {
        var Petr = new Test(5,"Petr");
        var Oleg = new Test(6,"Oleg");
        var list = new LinkedList<Test>();
        list.AddFirst(Petr);
        list.AddAfter(Petr,Oleg);
        list.AddBefore(Petr,null);
    }
}

class Test
{
    public int _count;
    public string _name;

    public Test(int count,string name)
    {
        _count = count;
        _name = name;
        
    }
}
