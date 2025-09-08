
namespace Chap_1;

public class Person
{
    public string Name { get; set; }
    public string Greeting => $"Hello, {Name}!";
    public override string ToString() => Name;

    public void Process()
    {
        int Square(int x) => x * x;
        Console.WriteLine(Square(5));

        Permissions userper = Permissions.Read | Permissions.Write;
        bool canWrite = (userper & Permissions.Write) == Permissions.Write;

        Console.WriteLine($"Can write: {canWrite}");
    }
}


[Flags]
enum Permissions
{
    None = 0,
    Read = 1,
    Write = 2,
}