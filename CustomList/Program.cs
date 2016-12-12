using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomBuiltList<string> testList = new CustomBuiltList<string>();
            Console.WriteLine(testList.Count());
            testList.Add("String 1");
            testList.Add("String 2");
            testList.Add("String 3");
            testList.Display();
            testList.Remove("String 3");
            testList.Display();
            //List<string> realListOfStrings = new List<String>();
            //realListOfStrings.Add("Hello");
            //Console.WriteLine(realListOfStrings.ToString());
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
