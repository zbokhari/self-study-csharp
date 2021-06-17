using System; // https://docs.microsoft.com/en-us/dotnet/api/system?view=net-5.0
using System.Collections.Generic; //https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic?view=net-5.0
                                    //gives access to stringList

namespace self_study_csharp
{
    class Program
    {
        static void Main(string[] args) //method
        { //beginning of statement block
            int x = 5*36; //basic integer multiplication
            List<string> stringList = new List<string>(); //stringList test
            stringList.Add("Welcome to");
            stringList.Add("Zain's self-study");
            stringList.Add("in .NET 5 and C# 9.");
            foreach (var part in stringList)
            {
                Console.WriteLine(part);
            }
            Console.WriteLine(x);
            Console.WriteLine("I will use this repo to initially test out what I am learning then build out more complex projects as my skills advance!");
        } //end of statement block
    }
    
}
