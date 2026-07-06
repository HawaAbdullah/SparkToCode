namespace CsharpFunctions;

class Program
{
    static void Main(string[] args)
    {
        Math.Cos(90);
        Console.WriteLine("hello");
        Console.Clear();

        double r = Math.Cos(90);
        Console.WriteLine(r);
        double res =Math.Pow(2, 3);
        Console.WriteLine("The Result is "+ res);
        
        // here the user will input math functions
        Console.WriteLine("enter number:");
        float userInput = float.Parse(Console.ReadLine());

        double result = Math.Cos(userInput);
        Console.WriteLine(result);
        
        Console.WriteLine("enter base number:");
        float baseNumber = float.Parse(Console.ReadLine());

        Console.WriteLine("enter power number:");
        float powerNumber = float.Parse(Console.ReadLine());

        double result2 = Math.Pow(baseNumber, powerNumber);
        Console.WriteLine(result2);
        

        
        
        
        
        
        



    }
}