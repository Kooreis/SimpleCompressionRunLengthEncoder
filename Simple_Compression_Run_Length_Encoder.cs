```CSharp
using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string to compress:");
        string input = Console.ReadLine();
        Console.WriteLine("Compressed string: " + RunLengthEncode(input));
    }

    static string RunLengthEncode(string input)
    {
        StringBuilder sb = new StringBuilder();
        int count = 1;
        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] == input[i - 1])
            {
                count++;
            }
            else
            {
                sb.Append(input[i - 1]);
                sb.Append(count);
                count = 1;
            }
        }
        sb.Append(input[input.Length - 1]);
        sb.Append(count);
        return sb.ToString();
    }
}
```