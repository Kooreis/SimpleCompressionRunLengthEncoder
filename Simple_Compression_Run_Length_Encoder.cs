class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string to compress:");
        string input = Console.ReadLine();
        Console.WriteLine("Compressed string: " + RunLengthEncode(input));
    }