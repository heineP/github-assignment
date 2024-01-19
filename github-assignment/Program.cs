namespace github_assignment;

class Program
{    // hello  :)
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("My name is Heine");
        CountTo(3);
    }
    // Counts from 1 to parameter
    static void CountTo(int num)
    {
        for (int i = 1; i <= num; i++)
        {
            Console.WriteLine(i);
        }
    }
}

