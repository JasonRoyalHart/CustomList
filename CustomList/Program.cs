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
            CustomBuiltList<string> testList2 = new CustomBuiltList<string>();
            CustomBuiltList<string> testList3 = new CustomBuiltList<string>();
            testList.Add("Hello");
            testList.Add("World");
            testList.Add("Blargh");
            testList2.Add("Martians");
            testList2.Add("Are");
            testList2.Add("Invading");

            testList3 = testList.Zip(testList2);
            testList3.Display();
            testList3.Sort();
            testList3.Display();
//            Console.WriteLine(testList.elements[0]);



 //           testList.Display();

            //testList3 = testList - testList2;
            //testList3.Display();
            ////List<string> realListOfStrings = new List<String>();
            ////realListOfStrings.Add("Hello");
            ////Console.WriteLine(realListOfStrings.ToString());
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
