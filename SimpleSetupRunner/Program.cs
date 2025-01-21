using SimpleSetup;

namespace SimpleSetupRunner;

public class Program
{
    public static void Main(string[] args)
    {
        var test = new SimpleClass().Hello();
        Console.WriteLine($"{test} Hello, World!");
        Console.WriteLine("Waiting for input");
        Console.WriteLine(WriteSomething());
    }

    public static string WriteSomething()
    {
        Console.WriteLine("Write something please: ");
        return Console.ReadLine();
    }
}
