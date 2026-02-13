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



//using System;
//using System.Linq;
//using System.Collections.Generic;
//class Program
//{
//    static void Main()
//    {
//        List<int> numbers = new List<int> { 10, 20, 30, 40, 50, 60 };
//        int half = numbers.Count / 2;
//        List<int> list1=numbers.Take(half).ToList();
//        List<int> list2=numbers.Skip(half).ToList();

//        Console.WriteLine("list1:");
//        foreach(var n in list1)
//        {
//            Console.WriteLine(n); 
//        }
//        Console.WriteLine("list2:");
//        foreach(var n in list2)
//        {
//            Console.WriteLine(n);
//        }
//    }
//}

//using System;
//using System.Collections.Generic;
//class Student
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public int Age { get; set; }
//}
//class Program
//{
//    static void Main()
//    {
//        // Creating a List
//        List<Student> students = new List<Student>();


//        // Adding students
//        students.Add(new Student { Id = 1, Name = "Ravi", Age = 20 });
//        students.Add(new Student { Id = 2, Name = "Kumar", Age = 22 });
//        students.Add(new Student { Id = 3, Name = "Priya", Age = 19 });

//        Console.WriteLine("Total Students: " + students.Count);
//        Console.WriteLine();

//        // Accessing by index
//        Console.WriteLine("First Student: " + students[0].Name);
//        Console.WriteLine();

//        // Updating student
//        students[1].Age = 23;

//        // Removing student
//        students.RemoveAt(2);

//        Console.WriteLine("After Update and Remove:");
//        Console.WriteLine("Total Students: " + students.Count);
//        Console.WriteLine();

//        // Sorting list by Age
//        students.Sort((s1, s2) => s1.Age.CompareTo(s2.Age));

//        Console.WriteLine("Sorted by Age:");
//        foreach (var student in students)
//        {
//            Console.WriteLine(student.Id + " - " + student.Name + " - " + student.Age);
//        }

//        Console.ReadLine();
//    }
//}



//using System;
//using System.Linq;
//using System.Collections;
//class Program
//{
//    static void Main()
//    {
//        ArrayList list = new ArrayList() { 1, "Shivansh", "Btech", 20000, 50, "Hello" };
//        IEnumerable<int> intValue = list.OfType<int>().ToList();
//        Console.WriteLine("Integer Value:");
//        foreach (var n in intValue)
//        {
//            Console.WriteLine(n);
//        }
//    }
//}


//using System;
//using System.Linq;
//using System.Collections;
//class Program
//{
//    static void Main()
//    {
//        int[] numbers = { 1, 2, 3, 6, 7, 8, 4, 9 };
//        IEnumerable<int> result = numbers.SkipWhile(n => n < 5);
//        Console.WriteLine("Result after skip:");
//        foreach (var n in result)
//        {
//            Console.WriteLine(n);
//        }
//    }
//}



//using System;
//using System.Linq;
//using System.Collections;
//class Program
//{
//    static void Main()
//    {
//        int[] numbers = {5,4,1,3,9,8,6,7,2,0};
//        var firstNumbersLessThan6 = numbers.TakeWhile(n => n < 6);
//        Console.WriteLine("Result:");
//        foreach (var n in firstNumbersLessThan6)
//        {
//            Console.WriteLine(n);
//        }
//    }
//}


using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4 };

        IEnumerable<int> result = numbers.Where(x => x > 2);

        //var result = numbers.Where(x => x > 2).ToList();

        numbers.Add(10);

        foreach (var n in result)
        {
            Console.WriteLine(n);
        }
    }
}