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
        
        //this is data and time fun
        DateTime currentTiming = DateTime.Now;
        Console.WriteLine(currentTiming);

        DateTime timing = DateTime.Today;
        Console.WriteLine(timing);
        
        
        DateTime startSubscription = DateTime.Today;
        DateTime endSubscription = startSubscription.AddDays(30);

        Console.WriteLine("your subscription ends on: " + endSubscription);
        
        //stringName.functionName(parameters)

        Console.WriteLine("enter a word:");
        string word = Console.ReadLine();

        int length = word.Length;              // returns length of string
        word.Substring(7, 5);                  // extracts part of string
        string upperedWord = word.ToUpper();   // convert to uppercase
        string loweredWord = word.ToLower();   // convert to lowercase
        
        /////////////////////
        string name = "Ahmed";

        Console.WriteLine("enter your name:");
        string input = Console.ReadLine();

        
        if (input.ToUpper() == name.ToUpper())
        {
            Console.WriteLine("welcome to application, successful sign in");
        }
        else
        {
            Console.WriteLine("invalid name, please try again");
        }
        
        bool containsResult = word.Contains("hi");





        
        
        
        
        
        



    }
}