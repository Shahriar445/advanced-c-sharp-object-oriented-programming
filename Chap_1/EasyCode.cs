
namespace Chap_1;

public class EasyCode
{
    
}

public class Person
{
    public string Name { get; set; }
    public string Greeting => $"Hello,{Name}!";
    public override string ToString() => Name;
    public void Process()
    {
        int Square(int x) => x * x;
        Console.WriteLine(Square(5));
    }

   


}


