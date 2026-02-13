//using System;
//using System.Linq;
//using System.Collections.Generic;
//class Program
//{
//    static void Main()
//    {
//        List<int> numbers = new List<int> { 10, 20, 30 };


//        //Deferred Execution
//        var deferredQuery = numbers.Where(n => n > 15);
//        numbers.Add(40);
//        Console.WriteLine("Deferred Execution result:");
//        foreach (var n in deferredQuery)
//        {
//            Console.WriteLine(n);
//        }


//        //Immediate Execution
//        var immediateResult = numbers.Where(n => n > 15).ToList();
//        numbers.Add(50);
//        Console.WriteLine("\nImmediation Execution result:");
//        foreach(var n in immediateResult)
//        {
//            Console.WriteLine(n); 
//        }

//    }
//}



using System;
using System.Linq;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 10, 20, 30, 40, 50, 60 };
        int half = numbers.Count / 2;
        List<int> list1=numbers.Take(half).ToList();
        List<int> list2=numbers.Skip(half).ToList();

        Console.WriteLine("list1:");
        foreach(var n in list1)
        {
            Console.WriteLine(n); 
        }
        Console.WriteLine("list2:");
        foreach(var n in list2)
        {
            Console.WriteLine(n);
        }
    }
}