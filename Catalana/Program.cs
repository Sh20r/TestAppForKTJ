using Catalana;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 15; i++)
        {
            Console.WriteLine($"n = {i} => {Class1.CountPairs(i)} combinations");
        }
    }
}

